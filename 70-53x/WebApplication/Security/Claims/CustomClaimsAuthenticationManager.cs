// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomClaimsAuthenticationManager.cs" company="70-53x">
//   70-53x
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace WebApplication.Security.Claims
{
    using System.Linq;
    using System.Security.Claims;

    using Microsoft.Azure.ActiveDirectory.GraphClient;

    using WebApplication.Helpers;
    using WebApplication.Tracing;

    /// <summary>
    /// The custom claims authentication manager.
    /// </summary>
    public class CustomClaimsAuthenticationManager : ClaimsAuthenticationManager
    {
        /// <summary>
        /// The active directory helper.
        /// </summary>
        private readonly ActiveDirectoryHelper activeDirectoryHelper = new ActiveDirectoryHelper();

        #region Public Methods and Operators

        /// <summary>
        /// The authenticate.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name.
        /// </param>
        /// <param name="incomingPrincipal">
        /// The incoming principal.
        /// </param>
        /// <returns>
        /// The <see cref="ClaimsPrincipal"/>.
        /// </returns>
        public override ClaimsPrincipal Authenticate(string resourceName, ClaimsPrincipal incomingPrincipal)
        {
            const string ObjectIdClaimType = "http://schemas.microsoft.com/identity/claims/objectidentifier";
            if (incomingPrincipal.Identity.IsAuthenticated)
            {
                var claimsIdentity = (ClaimsIdentity)incomingPrincipal.Identity;
                var client = this.activeDirectoryHelper.ActiveDirectoryClient;
                var user =
                    client.Users.Where(x => x.ObjectId == incomingPrincipal.FindFirst(ObjectIdClaimType).Value)
                        .Expand(x => x.MemberOf)
                        .ExecuteSingleAsync()
                        .Result;
                ApplicationEventSource.EventSource.Logon(user.UserPrincipalName);
                claimsIdentity.AddClaim(new Claim(claimsIdentity.NameClaimType, user.DisplayName));
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Upn, user.UserPrincipalName));
                foreach (var directoryObject in user.MemberOf.CurrentPage.OfType<IDirectoryRole>())
                {
                    var directoryRole = directoryObject;
                    claimsIdentity.AddClaim(new Claim(claimsIdentity.RoleClaimType, directoryRole.DisplayName));

                    // User Account Administrator, Company Administrator
                }
            }

            return incomingPrincipal;
        }

        #endregion
    }
}