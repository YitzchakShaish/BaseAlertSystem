using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAlertSystem
{
    internal class DroneDispatchAlert : IAlert
        {
            public void Alert()
            {
                Console.WriteLine("Activating a drone for alarm/ during an alarm.");
            }
        }
    
}
