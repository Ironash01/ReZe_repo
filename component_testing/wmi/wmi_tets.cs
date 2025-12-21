using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace ReZe.component_testing.wmi
{
    internal class wmi_test
    {
        static void Main()
        {
            // Query for process start events
            WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_ProcessStartTrace");

            ManagementEventWatcher watcher = new ManagementEventWatcher(query);
            watcher.EventArrived += new EventArrivedEventHandler(ProcessStarted);
            watcher.Start();

            Console.WriteLine("Listening for new process launches...");
            Console.ReadLine(); // Keep the app running
            watcher.Stop();
        }

        private static void ProcessStarted(object sender, EventArrivedEventArgs e)
        {
            string processName = e.NewEvent.Properties["ProcessName"].Value.ToString();
            string processId = e.NewEvent.Properties["ProcessID"].Value.ToString();
            Console.WriteLine($"Process started: {processName} (PID: {processId})");
        }
    }
}
