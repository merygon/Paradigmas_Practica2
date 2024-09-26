using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class PoliceStation
    {
        private bool Alarm {  get; set; }
        private List<string> PoliceCars { get; set; }
        
        private PoliceCar PoliceCar;

        public PoliceStation()
        {
            Alarm = false;
            // policeCar = new PoliceCar(string plate);
            PoliceCars = new List<string>();
        }

        public string RegisterCar(string plate)
        {
            PoliceCars.Add(plate);
            Console.WriteLine(PoliceCar.WriteMessage("registered."));
        }

        public void Alert()
        {
            Alarm = true;
            PoliceCar.ActivateAlarm();
        }
    }

}
