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
        /// <param name="upn">
        /// The user principal name.
        /// </param>
        [Event(2, Level = EventLevel.Informational, Message = "{0} was logged off.", Task = Tasks.Audit)]
        public void Logoff(string upn)
        {
            if (this.IsEnabled())
            {
                this.WriteEvent(2, upn);
            }
        }

        /// <summary>
        /// The logon event.
        /// </summary>
        /// <param name="upn">
        /// The user principal name.
        /// </param>
        [Event(1, Level = EventLevel.Informational, Message = "{0} was logged on.", Task = Tasks.Audit)]
        public void Logon(string upn)
        {
            if (this.IsEnabled())
            {
                this.WriteEvent(1, upn);
            }
        }

        /// <summary>
        /// The sync directory event.
        /// </summary>
        /// <param name="upn">
        /// The user principal name.
        /// </param>
        [Event(10, Level = EventLevel.Informational, Message = "{0} queued the directory synchronization", Task = Tasks.Sync)]
        public void SyncDirectory(string upn)
        {
            if (this.IsEnabled())
            {
                this.WriteEvent(10, upn);
            }
        }

        /// <summary>
        /// The sync user event.
        /// </summary>
        /// <param name="displayName">
        /// The user display name.
        /// </param>
        /// <param name="upn">
        /// The user principal name.
        /// </param>
        [Event(11, Level = EventLevel.Verbose, Message = "Synchronizing {0} ({1})", Task = Tasks.Sync)]
        public void SyncUser(string displayName, string upn)
        {
            if (this.IsEnabled())
            {
                this.WriteEvent(11, displayName, upn);
            }
        }

        /// <summary>
        /// The sync user done event.
        /// </summary>
        /// <param name="displayName">
        /// The user display name.
        /// </param>
        /// <param name="upn">
        /// The user principal name.
        /// </param>
        [Event(12, Level = EventLevel.Verbose, Message = "Synchronizing {0} ({1}) completed", Task = Tasks.Sync)]
        public void SyncUserDone(string displayName, string upn)
        {
            if (this.IsEnabled())
            {
                this.WriteEvent(12, displayName, upn);
            }
        }

        #endregion
    }
}