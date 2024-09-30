using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class PoliceStation: IMessageWritter
    {
        private List<PoliceCar> PoliceCars { get; set; }
        
        private PoliceCar PoliceCar;

        public PoliceStation()
        {
            PoliceCars = new List<PoliceCar>();
        }

        public void RegisterCar(PoliceCar PoliceCar)
        {
            PoliceCars.Add(PoliceCar);
            Console.WriteLine(WriteMessage($"registered police car with plate: {PoliceCar.GetPlate()}."));
        }

        public void Alert(VehicleWithPlate vehicle)
        {
            foreach (PoliceCar policeCar in PoliceCars)
            {
                if (policeCar.IsPatrolling())
                {
                    policeCar.ActivateAlarm();
                    Console.WriteLine(WriteMessage($"Activated alarm for police car with plate: {policeCar.GetPlate()}"));
                    policeCar.ChaseVehicle(vehicle);
                }
                else
                {
                    Console.WriteLine($"{policeCar.WriteMessage("Is not patrolling.")}");
                }
            }
        }

        public string WriteMessage(string message)
        {
            return $"Police Station: {message}";
        }


    }

}
