// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.Trace.cs" company="70-53x">
//   70-53x
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace WebApplication
{
    using System.Configuration;
    using System.Diagnostics.Tracing;

    using Microsoft.Practices.EnterpriseLibrary.SemanticLogging;

    using WebApplication.Tracing;

    /// <summary>
    /// The trace config.
    /// </summary>
    public partial class Startup
    {
        #region Public Methods and Operators

        /// <summary>
        /// Configures trace.
        /// </summary>
        public static void ConfigureTrace()
        {
            var listener = new ObservableEventListener();
            listener.LogToWindowsAzureTable(
                "WebApplication", 
                ConfigurationManager.ConnectionStrings["storage"].ConnectionString, 
                "events");
            listener.EnableEvents(ApplicationEventSource.EventSource, EventLevel.LogAlways);
        }

        #endregion
    }
}