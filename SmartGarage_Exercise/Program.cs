namespace SmartGarage_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

			Car car1 = new Car("Subaru Impreza", 20);
			Motorcycle bike1 = new Motorcycle("Kawasaki Ninja", 40);
			CleaningRobot robot1 = new CleaningRobot("S-500", 15);

			
            Console.WriteLine("\n\n--- Welcome to Smart Garage (v2.0 - Refactored!) ---");
            Drone drone1 = new Drone("DJI-Mavic", 30);
            Vehicle[] allVehicles = { car1, bike1 };

            Imoveable [] allMovables = { car1, bike1, robot1, drone1 };

            SmartGarageTester.TestAllVehicles(allVehicles);
            SmartGarageTester.TestMovablesAndChargeables(allMovables);

            robot1.StartCleaning();
            drone1.Fly();
            
		}
	}

}
    

