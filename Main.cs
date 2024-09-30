namespace Practice1
{
    internal class Program
    {

        static void Main()
        {
            SpeedRadar radar = new SpeedRadar();
            Scooter scooter = new Scooter(100);
            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            PoliceStation policeStation = new PoliceStation();
            PoliceCar policeCar1 = new PoliceCar("0001 CNP", policeStation, radar);
            PoliceCar policeCar2 = new PoliceCar("0002 CNP", policeStation);
            PoliceCar policeCar3 = new PoliceCar("0003 CNP", policeStation, radar);
            City city = new City();
            

            Console.WriteLine(taxi1.WriteMessage("Created."));
            Console.WriteLine(taxi2.WriteMessage("Created."));
            Console.WriteLine(policeCar1.WriteMessage("Created."));
            Console.WriteLine(policeCar2.WriteMessage("Created."));
            Console.WriteLine(policeCar3.WriteMessage("Created."));
            Console.WriteLine(city.WriteMessage("Created."));
            Console.WriteLine(policeStation.WriteMessage("Created."));

            city.RegisterLicense(taxi1.GetPlate());
            city.RegisterLicense(taxi2.GetPlate());
            policeStation.RegisterCar(policeCar1);
            policeStation.RegisterCar(policeCar2);
            policeStation.RegisterCar(policeCar3);


            policeCar3.StartPatrolling();

            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);

            taxi2.StartRide();
            policeCar2.UseRadar(taxi2);
            policeCar2.StartPatrolling();
            policeCar2.UseRadar(taxi2);
            taxi2.StopRide();
            policeCar2.EndPatrolling();

            taxi1.StartRide();
            taxi1.StartRide();
            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);
            taxi1.StopRide();
            taxi1.StopRide();
            city.RetireLicense(taxi1.GetPlate());
            policeCar1.EndPatrolling();

            policeCar1.PrintRadarHistory();
            policeCar2.PrintRadarHistory();

        }
    }
}
    

