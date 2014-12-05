// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="70-53x">
//   70-53x
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace WebApplication.Controllers
{
    using System.Web.Mvc;
    
    /// <summary>
    /// The home controller.
    /// </summary>
    public class HomeController : Controller
    {
        #region Public Methods and Operators
        
        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Index()
        {
            return this.View(); // [Authorize(Roles = "Company Administrator, User Account Administrator")]
        }

        #endregion
    }
}