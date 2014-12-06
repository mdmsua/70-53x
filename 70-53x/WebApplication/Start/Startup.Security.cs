// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.Security.cs" company="70-53x">
//   70-53x
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace WebApplication
{
    using System.Configuration;
    using System.IdentityModel.Claims;
    using System.IdentityModel.Tokens;
    using System.Web.Helpers;

    using Microsoft.Owin.Security;
    using Microsoft.Owin.Security.ActiveDirectory;
    using Microsoft.Owin.Security.Cookies;

    using Owin;

    /// <summary>
    ///     The startup.
    /// </summary>
    public partial class Startup
    {
        #region Methods

        /// <summary>
        /// The configure security.
        /// </summary>
        /// <param name="app">
        /// The app.
        /// </param>
        private static void ConfigureSecurity(IAppBuilder app)
        {
            string realm = ConfigurationManager.AppSettings["realm"];
            string audience = ConfigurationManager.AppSettings["audience"];
            string metadataAddress = ConfigurationManager.AppSettings["MetadataAddress"];
            var tokenValidationParameters = new TokenValidationParameters
                                                {
                                                    ValidAudience = audience, 
                                                    ValidAudiences = new[] { audience }
                                                };
            var authenticationOptions = new WindowsAzureActiveDirectoryBearerAuthenticationOptions
                                            {
                                                Realm = realm, 
                                                MetadataAddress =
                                                    metadataAddress, 
                                                TokenValidationParameters
                                                    =
                                                    tokenValidationParameters
                                            };

            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);
            app.UseCookieAuthentication(new CookieAuthenticationOptions());
            app.UseWindowsAzureActiveDirectoryBearerAuthentication(authenticationOptions);

            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.Upn;
        }

        #endregion
    }
}