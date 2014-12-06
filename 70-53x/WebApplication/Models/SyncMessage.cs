// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SyncMessage.cs" company="70-53x">
//   70-53x
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace WebApplication.Models
{
    using Microsoft.Azure.ActiveDirectory.GraphClient;

    /// <summary>
    ///     The sync message.
    /// </summary>
    public class SyncMessage
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncMessage"/> class.
        /// </summary>
        /// <param name="user">
        /// The user.
        /// </param>
        /// <param name="manager">
        /// The manager.
        /// </param>
        public SyncMessage(User user, string manager)
        {
            this.User = user;
            this.Manager = manager;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the User's manager.
        /// </summary>
        public string Manager { get; set; }

        /// <summary>
        ///     Gets or sets the User.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the tenant id.
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets the client id.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the client secret.
        /// </summary>
        public string ClientSecret { get; set; }

        #endregion
    }
}