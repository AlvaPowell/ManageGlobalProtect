using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace ManageGlobalProtect
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceController controller = new ServiceController("PanGPS");



            if (controller.Status == ServiceControllerStatus.Stopped)
            {
                controller.Start();
                controller.WaitForStatus(ServiceControllerStatus.StartPending);
            }
            else
            {
                controller.Stop();
                controller.WaitForStatus(ServiceControllerStatus.Stopped); 
            }

            Console.WriteLine("Service status: " + controller.Status);
            Console.ReadLine();
        }
    }
}
