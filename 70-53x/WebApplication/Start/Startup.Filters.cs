// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.Filters.cs" company="70-53x">
//   70-53x
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace WebApplication
{
    using System.Web.Mvc;

    /// <summary>
    /// The startup.
    /// </summary>
    public partial class Startup
    {
        #region Methods

        /// <summary>
        /// The configure filters.
        /// </summary>
        /// <param name="filters">
        /// The filters.
        /// </param>
        private static void ConfigureFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new RequireHttpsAttribute());
        }

        #endregion
    }
}