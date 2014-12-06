// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Functions.cs" company="70-53x">
//   70-53x
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace WebJob
{
    using System.Threading.Tasks;

    using Microsoft.Azure.ActiveDirectory.GraphClient;
    using Microsoft.Azure.WebJobs;

    using Newtonsoft.Json;

    using WebApplication.Helpers;
    using WebApplication.Models;
    using WebApplication.Tracing;

    using WebJob.Annotations;

    /// <summary>
    ///     The functions.
    /// </summary>
    [UsedImplicitly]
    public class Functions
    {
        #region Public Methods and Operators

        /// <summary>
        /// The job to sync active directory.
        /// </summary>
        /// <param name="queueMessage">
        /// The queue message.
        /// </param>
        [UsedImplicitly]
        public static void SyncActiveDirectory([QueueTrigger("sync")] string queueMessage)
        {
            var message = JsonConvert.DeserializeObject<SyncMessage>(queueMessage);
            ActiveDirectoryClient client =
                new ActiveDirectoryHelper(message.TenantId, message.ClientId, message.ClientSecret)
                    .ActiveDirectoryClient;
            ProcessSyncMessage(message, client).Wait();
        }

        #endregion

        #region Methods

        /// <summary>
        /// The process sync message.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="client">
        /// The client.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        private static async Task ProcessSyncMessage(SyncMessage message, ActiveDirectoryClient client)
        {
            ApplicationEventSource.EventSource.SyncUser(message.User.DisplayName, message.User.UserPrincipalName);
            var directoryUser = await client.Users.GetByObjectId(message.User.ObjectId).ExecuteAsync();
            if (directoryUser == null)
            {
                IGroup group = await client.Groups.Where(x => x.DisplayName == message.User.Department).ExecuteSingleAsync();
                if (@group != null)
                {
                    message.User.MemberOf.Add((Group)@group);
                }

                message.User.Manager = await client.Users.Where(u => u.ObjectId == message.Manager).ExecuteSingleAsync() as User;
                await client.Users.AddUserAsync(message.User);
            }

            ApplicationEventSource.EventSource.SyncUserDone(message.User.DisplayName, message.User.UserPrincipalName);
        }

        #endregion
    }
}