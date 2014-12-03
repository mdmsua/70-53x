// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActiveDirectoryHelper.cs" company="70-53x">
//   70-53x
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace WebApplication.Helpers
{
    using System;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;

    using Microsoft.Azure.ActiveDirectory.GraphClient;
    using Microsoft.IdentityModel.Clients.ActiveDirectory;

    /// <summary>
    /// The active directory helper.
    /// </summary>
    public class ActiveDirectoryHelper
    {
        #region Static Fields

        /// <summary>
        /// The client id.
        /// </summary>
        private static readonly string ClientId = ConfigurationManager.AppSettings["ida:ClientId"];

        /// <summary>
        /// The client secret.
        /// </summary>
        private static readonly string ClientSecret = ConfigurationManager.AppSettings["ida:ClientSecret"];

        /// <summary>
        /// The tenant id.
        /// </summary>
        private static readonly string TenantId = ConfigurationManager.AppSettings["ida:TenantId"];

        /// <summary>
        /// The graph API base endpoint.
        /// </summary>
        private static readonly Uri GraphUri = new Uri("https://graph.windows.net/");

        /// <summary>
        /// The login endpoint.
        /// </summary>
        private static readonly Uri LoginUri = new Uri("https://login.windows.net/");

        /// <summary>
        /// The graph API endpoint (e.g. https://graph.windows.net/{tenant}/).
        /// </summary>
        private static readonly Uri GraphApiEndpoint = new Uri(GraphUri, TenantId);

        /// <summary>
        /// The federation sign-on endpoint (e.g. https://graph.windows.net/{tenant}/wsfed/).
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        private static readonly Uri WsFederationSignOn = new Uri(LoginUri, string.Join("/", TenantId, "wsfed"));

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the active directory client.
        /// </summary>
        public ActiveDirectoryClient ActiveDirectoryClient
        {
            get
            {
                return new ActiveDirectoryClient(GraphApiEndpoint, async () => await GetAccessTokenAsync());
            }
        }

        #endregion

        #region Methods

        /// <summary>
        ///     The access token getter.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        private static async Task<string> GetAccessTokenAsync()
        {
            var context = new AuthenticationContext(WsFederationSignOn.ToString(), false);
            AuthenticationResult token =
                await context.AcquireTokenAsync(GraphUri.ToString(), new ClientCredential(ClientId, ClientSecret));
            return token.AccessToken;
        }

        #endregion
    }
}