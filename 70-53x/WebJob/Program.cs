// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="70-53x">
//   70-53x
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace WebJob
{
    using Microsoft.Azure.WebJobs;

    /// <summary>
    /// The program.
    /// </summary>
    internal static class Program
    {
        // Please set the following connection strings in app.config for this WebJob to run:
        // AzureWebJobsDashboard and AzureWebJobsStorage
        #region Methods

        /// <summary>
        /// The main.
        /// </summary>
        private static void Main()
        {
            var host = new JobHost();
            host.RunAndBlock();
        }

        #endregion
    }
}