using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Scooter : Vehicle
    {
        private const string typeOfVehicle = "Scooter";

        public Scooter(float speed) : base(typeOfVehicle)
        {
        }
    }
}
