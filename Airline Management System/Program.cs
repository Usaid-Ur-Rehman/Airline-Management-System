using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Airline_Management_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Project_1st_
    {
        static class Program
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            private static readonly string MutexId = "YourApplicationUniqueMutexId";

            [STAThread]
            static void Main()
            {
                using (Mutex mutex = new Mutex(true, MutexId, out bool createdNew))
                {
                    // Check if this instance of the application is already running
                    if (!createdNew)
                    {
                        // Another instance is running, exit the application
                        MessageBox.Show("Another instance of the application is already running.", "AirLineManagementSystem",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                        return;
                    }
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Server());
                }
            }
        }
    }
}
