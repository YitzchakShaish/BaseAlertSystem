using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAlertSystem
{
    internal class BaseDefenseController
    {
        private SirenAlert alert = new SirenAlert();

        public void DetectThreat()
        {
            Console.WriteLine("Alarm activation");
            alert.Alert();
        }
        
    }
}
