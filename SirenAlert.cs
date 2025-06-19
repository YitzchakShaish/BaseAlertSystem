using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAlertSystem
{
    internal class SirenAlert: IAlert
    {
        public void Alert()
        {
            Console.WriteLine("Alarm sound goes up and down");
        }
    }
}
