// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="70-53x">
//   70-53x
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Microsoft.Owin;

using WebApplication;

[assembly: OwinStartup(typeof(Startup))]

namespace WebApplication
{
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using Owin;

    /// <summary>
    ///     The startup.
    /// </summary>
    public partial class Startup
    {
        #region Public Methods and Operators

        /// <summary>
        /// The configuration.
        /// </summary>
        /// <param name="app">
        /// The app.
        /// </param>
        public void Configuration(IAppBuilder app)
        {
            ConfigureFilters(GlobalFilters.Filters);
            ConfigureBundles(BundleTable.Bundles);
            ConfigureRoutes(RouteTable.Routes);
            ConfigureSecurity(app);
            ConfigureTrace();
        }

        #endregion
    }
}