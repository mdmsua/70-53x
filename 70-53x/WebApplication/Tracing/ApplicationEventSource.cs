// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationEventSource.cs" company="70-53x">
//   70-53x
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace WebApplication.Tracing
{
    using System;
    using System.Diagnostics.Tracing;

    /// <summary>
    ///     The application event source.
    /// </summary>
    [EventSource(Name = "70-53x")]
    public class ApplicationEventSource : EventSource
    {
        #region Static Fields

        /// <summary>
        ///     The instance.
        /// </summary>
        private static readonly Lazy<ApplicationEventSource> Instance =
            new Lazy<ApplicationEventSource>(() => new ApplicationEventSource());

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Prevents a default instance of the <see cref="ApplicationEventSource" /> class from being created.
        /// </summary>
        private ApplicationEventSource()
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the event source.
        /// </summary>
        public static ApplicationEventSource EventSource
        {
            get
            {
                return Instance.Value;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The logoff event.
        /// </summary>
        /// <param name="account">
        /// The account.
        /// </param>
        [Event(2, Level = EventLevel.Informational, Message = "{0} was logged off.")]
        public void Logoff(string account)
        {
            if (this.IsEnabled())
            {
                this.WriteEvent(2, account);
            }
        }

        /// <summary>
        /// The logon event.
        /// </summary>
        /// <param name="account">
        /// The account.
        /// </param>
        [Event(1, Level = EventLevel.Informational, Message = "{0} was logged on.")]
        public void Logon(string account)
        {
            if (this.IsEnabled())
            {
                this.WriteEvent(1, account);
            }
        }

        #endregion
    }
}