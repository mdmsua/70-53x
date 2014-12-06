// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DirectoryController.cs" company="70-53x">
//   70-53x
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace WebApplication.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.Entity;
    using System.Globalization;
    using System.Linq;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using Microsoft.Azure.ActiveDirectory.GraphClient;
    using Microsoft.Azure.ActiveDirectory.GraphClient.Extensions;
    using Microsoft.Data.OData;
    using Microsoft.WindowsAzure.Storage;
    using Microsoft.WindowsAzure.Storage.Queue;

    using Newtonsoft.Json;

    using WebApplication.Data;
    using WebApplication.Helpers;
    using WebApplication.Models;
    using WebApplication.Tracing;

    /// <summary>
    ///     The directory controller.
    /// </summary>
    [Authorize(Roles = "Company Administrator, User Account Administrator")]
    public class DirectoryController : Controller
    {
        #region Static Fields

        /// <summary>
        ///     The client id.
        /// </summary>
        private static readonly string ClientId = ConfigurationManager.AppSettings["ClientId"];

        /// <summary>
        ///     The client secret.
        /// </summary>
        private static readonly string ClientSecret = ConfigurationManager.AppSettings["ClientSecret"];

        /// <summary>
        ///     The storage connection string.
        /// </summary>
        private static readonly string StorageConnectionString =
            ConfigurationManager.ConnectionStrings["Storage"].ConnectionString;

        /// <summary>
        ///     The tenant id.
        /// </summary>
        private static readonly string TenantId = ConfigurationManager.AppSettings["TenantId"];

        #endregion

        #region Fields

        /// <summary>
        ///     The client.
        /// </summary>
        private readonly ActiveDirectoryClient client = new ActiveDirectoryHelper().ActiveDirectoryClient;

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The index.
        /// </summary>
        /// <returns>
        ///     The <see cref="System.Threading.Tasks.Task" />.
        /// </returns>
        public async Task<ActionResult> Index()
        {
            IPagedCollection<IUser> userQuery = await this.client.Users.ExecuteAsync();
            var users = new List<IUser>(userQuery.CurrentPage);
            while (userQuery.MorePagesAvailable)
            {
                await userQuery.GetNextPageAsync();
                users.AddRange(userQuery.CurrentPage);
            }

            return this.View(users);
        }

        /// <summary>
        ///     The sync action.
        /// </summary>
        /// <returns>
        ///     The <see cref="System.Threading.Tasks.Task" />.
        /// </returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Sync()
        {
            string upn = ((ClaimsIdentity)this.User.Identity).FindFirst(ClaimTypes.Upn).Value;

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(StorageConnectionString);

            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();
            CloudQueue syncQueue = queueClient.GetQueueReference("sync");
            await syncQueue.CreateIfNotExistsAsync();

            ApplicationEventSource.EventSource.SyncDirectory(upn);
            using (var context = new AdventureWorksContext())
            {
                HumanResourcesEmployee ceo =
                    await context.HumanResourcesEmployee.SingleAsync(x => x.OrganizationLevel == 0);
                string managerId = null;
                foreach (HumanResourcesEmployee employee in
                    context.HumanResourcesEmployee.OrderBy(x => x.OrganizationLevel).ToList())
                {
                    if (employee.OrganizationLevel > 0)
                    {
                        HumanResourcesEmployee manager =
                            context.HumanResourcesEmployee.SingleOrDefault(
                                e => e.OrganizationNode == employee.OrganizationNode.GetAncestor(1)) ?? ceo;
                        managerId = new Guid(manager.BusinessEntityId, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0).ToString();
                    }

                    await this.SyncEmployee(employee, managerId); // await QueueMessage(employee, manager, syncQueue);
                }
            }

            return this.RedirectToAction("Index");
        }

        /// <summary>
        /// The users action.
        /// </summary>
        /// <param name="upn">
        /// The user principal name.
        /// </param>
        /// <returns>
        /// The <see cref="System.Threading.Tasks.Task"/>.
        /// </returns>
        [ActionName("User")]
        public async Task<ActionResult> Users(string upn)
        {
            IUser user = await this.client.Users.Where(x => x.UserPrincipalName == upn).ExecuteSingleAsync();
            if (user == null)
            {
                return this.HttpNotFound();
            }

            return this.View(user);
        }

        #endregion

        #region Methods

        /// <summary>
        /// The convert employee to user.
        /// </summary>
        /// <param name="employee">
        /// The employee.
        /// </param>
        /// <returns>
        /// The <see cref="User"/>.
        /// </returns>
        private static User ConvertEmployeeToUser(HumanResourcesEmployee employee)
        {
            PersonAddress address =
                employee.PersonPerson.PersonBusinessEntity.PersonBusinessEntityAddress.Single().PersonAddress;
            string login = employee.LoginId.Substring(employee.LoginId.IndexOf('\\') + 1);
            string name = GetDisplayName(employee.PersonPerson);
            return new User
                       {
                           ObjectId = new Guid(employee.BusinessEntityId, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0).ToString(),
                           AccountEnabled = true, 
                           DisplayName = name, 
                           GivenName = employee.PersonPerson.FirstName, 
                           UserPrincipalName = string.Concat(login, "@7053x.onmicrosoft.com"), 
                           MailNickname = login, 
                           Surname = employee.PersonPerson.LastName, 
                           JobTitle = employee.JobTitle, 
                           Department =
                               employee.HumanResourcesEmployeeDepartmentHistory.Single(
                                   edh => edh.EndDate.HasValue == false).HumanResourcesDepartment.Name, 
                           TelephoneNumber = employee.PersonPerson.PersonPersonPhone.Single().PhoneNumber, 
                           StreetAddress = string.Join(" ", address.AddressLine1, address.AddressLine2), 
                           City = address.City, 
                           State = address.PersonStateProvince.Name, 
                           PostalCode = address.PostalCode, 
                           Country = address.PersonStateProvince.PersonCountryRegion.Name, 
                           PasswordProfile =
                               new PasswordProfile { Password = "7053xAW2014", ForceChangePasswordNextLogin = false }, 
                           PasswordPolicies = "DisablePasswordExpiration,DisableStrongPassword"
                       };
        }

        /// <summary>
        /// The get display name.
        /// </summary>
        /// <param name="person">
        /// The person.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private static string GetDisplayName(PersonPerson person)
        {
            const string Format = "{0} ";
            var sb = new StringBuilder();
            if (!string.IsNullOrEmpty(person.Title))
            {
                sb.AppendFormat(Format, person.Title);
            }

            sb.AppendFormat(Format, person.FirstName);
            sb.AppendFormat(Format, person.MiddleName);
            sb.AppendFormat(Format, person.LastName);
            if (!string.IsNullOrEmpty(person.Suffix))
            {
                sb.AppendFormat(Format, person.Suffix);
            }

            return sb.ToString().TrimEnd(' ');
        }

        /// <summary>
        /// The queue message.
        /// </summary>
        /// <param name="employee">
        /// The employee.
        /// </param>
        /// <param name="manager">
        /// The manager.
        /// </param>
        /// <param name="syncQueue">
        /// The sync queue.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        private static async Task QueueMessage(
            HumanResourcesEmployee employee, 
            HumanResourcesEmployee manager, 
            CloudQueue syncQueue)
        {
            User user = ConvertEmployeeToUser(employee);
            var message = new SyncMessage(user, manager == null ? null : new Guid(manager.BusinessEntityId, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0).ToString())
                              {
                                  TenantId =
                                      TenantId, 
                                  ClientId =
                                      ClientId, 
                                  ClientSecret =
                                      ClientSecret
                              };
            string payload = JsonConvert.SerializeObject(message);
            await syncQueue.AddMessageAsync(new CloudQueueMessage(payload));
        }

        /// <summary>
        /// The sync user.
        /// </summary>
        /// <param name="employee">
        /// The employee.
        /// </param>
        /// <param name="manager">
        /// The employee's manager.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        private async Task SyncEmployee(HumanResourcesEmployee employee, string manager)
        {
            User user = ConvertEmployeeToUser(employee);
            HumanResourcesDepartment department =
                employee.HumanResourcesEmployeeDepartmentHistory.Single(edh => edh.EndDate.HasValue == false)
                    .HumanResourcesDepartment;
            var departmentId = new Guid(0, department.DepartmentId, department.DepartmentId, 0, 0, 0, 0, 0, 0, 0, 0).ToString();
            ApplicationEventSource.EventSource.SyncUser(user.DisplayName, user.UserPrincipalName);
            try
            {
                await this.client.Users.GetByObjectId(user.ObjectId).ExecuteAsync();
            }
            catch (ODataErrorException)
            {
                this.CreateUserAsync(manager, departmentId, department, user).Wait();
            }

            ApplicationEventSource.EventSource.SyncUserDone(user.DisplayName, user.UserPrincipalName);
        }

        private async Task CreateUserAsync(string manager, string departmentId, HumanResourcesDepartment department, User user)
        {
            try
            {
                IGroup directoryGroup = await this.client.Groups.GetByObjectId(departmentId).ExecuteAsync();
                var directoryGroupObject = (Group)directoryGroup;
                if (!user.MemberOf.Contains(directoryGroupObject))
                {
                    user.MemberOf.Add(directoryGroupObject);
                }

                if (!string.IsNullOrEmpty(manager))
                {
                    user.Manager = await this.client.Users.GetByObjectId(manager).ExecuteAsync() as User;
                }

                await this.client.Users.AddUserAsync(user);
            }
            catch (ODataErrorException)
            {
                this.CreateGroupAsync(departmentId, department).Wait();
            }
        }

        private async Task CreateGroupAsync(string departmentId, HumanResourcesDepartment department)
        {
            await
                this.client.Groups.AddGroupAsync(
                    new Group
                        {
                            ObjectId = departmentId,
                            DisplayName = department.Name,
                            Description = department.GroupName,
                            MailNickname = department.Name.ToLowerInvariant().Replace(' ', '_'),
                            MailEnabled = false,
                            SecurityEnabled = true
                        });
        }

        #endregion
    }
}