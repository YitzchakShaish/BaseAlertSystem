using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAlertSystem
{
    internal class BaseDefenseController
    {
        private IAlert alert ;


        public BaseDefenseController(IAlert alert)
        {
            this.alert = alert;
        }
        public void DetectThreat()
        {
            Console.WriteLine("Alarm activation");
            alert.Alert();
        }
        
    }
}
