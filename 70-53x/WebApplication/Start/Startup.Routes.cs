// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.Routes.cs" company="70-53x">
//   70-53x
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace WebApplication
{
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary>
    /// The startup.
    /// </summary>
    public partial class Startup
    {
        #region Public Methods and Operators

        /// <summary>
        /// The configure routes.
        /// </summary>
        /// <param name="routes">
        /// The routes.
        /// </param>
        public static void ConfigureRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", 
                "{controller}/{action}/{id}", 
                new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }

        #endregion
    }
}