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
    ///     The active directory helper.
    /// </summary>
    public class ActiveDirectoryHelper
    {
        #region Static Fields

        /// <summary>
        ///     The graph API base endpoint.
        /// </summary>
        private static readonly Uri GraphUri = new Uri("https://graph.windows.net/");

        /// <summary>
        ///     The login endpoint.
        /// </summary>
        private static readonly Uri LoginUri = new Uri("https://login.windows.net/");

        #endregion

        #region Fields

        /// <summary>
        ///     The client id.
        /// </summary>
        private readonly string clientId = ConfigurationManager.AppSettings["ClientId"];

        /// <summary>
        ///     The client secret.
        /// </summary>
        private readonly string clientSecret = ConfigurationManager.AppSettings["ClientSecret"];

        /// <summary>
        ///     The tenant id.
        /// </summary>
        private readonly string tenantId = ConfigurationManager.AppSettings["TenantId"];

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDirectoryHelper"/> class.
        /// </summary>
        public ActiveDirectoryHelper()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDirectoryHelper"/> class.
        /// </summary>
        /// <param name="tenantId">
        /// The tenant id.
        /// </param>
        /// <param name="clientId">
        /// The client id.
        /// </param>
        /// <param name="clientSecret">
        /// The client secret.
        /// </param>
        public ActiveDirectoryHelper(string tenantId, string clientId, string clientSecret)
        {
            this.tenantId = tenantId;
            this.clientId = clientId;
            this.clientSecret = clientSecret;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the active directory client.
        /// </summary>
        public ActiveDirectoryClient ActiveDirectoryClient
        {
            get
            {
                return new ActiveDirectoryClient(this.GraphApiEndpoint, async () => await this.GetAccessTokenAsync());
            }
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the graph API endpoint (e.g. https://graph.windows.net/{tenant}/).
        /// </summary>
        private Uri GraphApiEndpoint
        {
            get
            {
                return new Uri(GraphUri, this.tenantId);
            }
        }

        /// <summary>
        ///     Gets the federation sign-on endpoint (e.g. https://graph.windows.net/{tenant}/wsfed/).
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", 
            Justification = "Reviewed. Suppression is OK here.")]
        private Uri WsFederationSignOn
        {
            get
            {
                return new Uri(LoginUri, string.Join("/", this.tenantId, "wsfed"));
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
        private async Task<string> GetAccessTokenAsync()
        {
            var context = new AuthenticationContext(this.WsFederationSignOn.ToString(), false);
            AuthenticationResult token =
                await
                context.AcquireTokenAsync(GraphUri.ToString(), new ClientCredential(this.clientId, this.clientSecret));
            return token.AccessToken;
        }

        #endregion
    }
}