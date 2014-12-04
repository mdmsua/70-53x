// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountController.cs" company="70-53x">
//   70-53x
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace WebApplication.Controllers
{
    using System;
    using System.IdentityModel.Services;
    using System.IdentityModel.Services.Configuration;
    using System.Security.Claims;
    using System.Web;
    using System.Web.Mvc;

    using WebApplication.Tracing;

    /// <summary>
    /// The account controller.
    /// </summary>
    public class AccountController : Controller
    {
        #region Public Methods and Operators

        /// <summary>
        /// The sign out.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult SignOut()
        {
            ApplicationEventSource.EventSource.Logoff(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Upn).Value);
            
            WsFederationConfiguration config = FederatedAuthentication.FederationConfiguration.WsFederationConfiguration;

            // Redirect to SignOutCallback after signing out.
            string callbackUrl = this.Url.Action(
                "SignOutCallback", 
                "Account", 
                null, 
                this.Request.Url == null ? "https" : this.Request.Url.Scheme);
            var signoutMessage = new SignOutRequestMessage(new Uri(config.Issuer), callbackUrl);
            signoutMessage.SetParameter("wtrealm", config.Realm);
            
            Request.GetOwinContext().Authentication.SignOut();
            
            return new RedirectResult(signoutMessage.WriteQueryString());
        }

        /// <summary>
        /// The sign out callback.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult SignOutCallback()
        {
            if (this.Request.IsAuthenticated)
            {
                // Redirect to home page if the user is authenticated.
                return this.RedirectToAction("Index", "Home");
            }

            return this.View();
        }

        #endregion
    }
}