using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;


/*
 * 
 * Tracks the system for game launching.
*/
namespace ReZe
{
    internal class wmi_processmonitor
    {
        ManagementEventWatcher proc_monitor;

        private void start_monitor()
        {
            var query = new WqlEventQuery("SELECT * FROM Win32_ProcessStartTrace");

            proc_monitor = new ManagementEventWatcher(query);
            proc_monitor.EventArrived += ProcessStarted;
            proc_monitor.Start();
        }
    }
}
