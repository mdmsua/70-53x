// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tasks.cs" company="70-53x">
//   70-53x
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace WebApplication.Tracing
{
    using System.Diagnostics.Tracing;

    /// <summary>
    /// The task.
    /// </summary>
    public static class Tasks
    {
        #region Constants

        /// <summary>
        /// The audit task.
        /// </summary>
        public const EventTask Audit = (EventTask)1;

        /// <summary>
        /// The sync task.
        /// </summary>
        public const EventTask Sync = (EventTask)2;

        #endregion
    }
}