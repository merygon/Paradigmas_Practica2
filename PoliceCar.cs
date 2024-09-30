namespace Practice1
{
    class PoliceCar : VehicleWithPlate
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car"; 
        private bool isPatrolling;
        private bool chasing;
        private SpeedRadar? speedRadar; // pueder ser null si no se proporciona
        private PoliceStation policeStation;


        public PoliceCar(string plate, PoliceStation policeStation, SpeedRadar? radar = null) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            chasing = false;
            speedRadar = radar;
            this.policeStation = policeStation;
        }

        public void UseRadar(VehicleWithPlate vehicle)
        {
            if (isPatrolling && speedRadar != null)
            {
                speedRadar.TriggerRadar(vehicle);
                string meassurement = speedRadar.GetLastReading();
                Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));
                if (vehicle.GetSpeed() > speedRadar.GetLegalSpeed())
                {
                    policeStation.Alert(vehicle); 
                }
            }
            else
            {
                Console.WriteLine(WriteMessage($"has no active radar."));
            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            if (speedRadar != null)
            {
                Console.WriteLine(WriteMessage("Report radar speed history:"));
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }
            }
            else
            {
                Console.WriteLine(WriteMessage("has no radar."));
            }
            
        }

        public bool IsChasing()
        {
            return chasing;
        }
        public void ActivateAlarm()
        {
            chasing = true;
        }

        public void DeactivateAlarm()
        {
            chasing = false;
        }

        public void ChaseVehicle(VehicleWithPlate vehicle)
        {
            if (chasing == true)
            {
                Console.WriteLine(WriteMessage($"chasing vehicle with plate: {vehicle.GetPlate()}."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is not chasing any vehicle."));
            }
        }
    }
}