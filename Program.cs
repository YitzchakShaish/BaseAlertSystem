using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAlertSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAlert alert = new SirenAlert();
            BaseDefenseController bdc = new BaseDefenseController(alert);
            bdc.DetectThreat();
            IAlert alert2 = new DroneDispatchAlert();
            BaseDefenseController bdc2 = new BaseDefenseController(alert2);
            bdc2.DetectThreat();



        }
    }
}
