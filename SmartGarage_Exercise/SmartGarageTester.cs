using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{

	public static class SmartGarageTester
	{
	

        public static void TestMovablesAndChargeables(Imoveable[] movables)
        {
            Console.WriteLine("\n--- Commencing Movable/Chargeable test ---");

            foreach (var v in movables)
            {
                ((Imoveable)(v)).MoveRight();
                if (v is IChargeable c)
                {
                    c.ChargeBattry();
                }
                
            }


            Console.WriteLine("--- Movable/Chargeable test complete ---");
        }

        public static void TestAllVehicles(Vehicle[] allVehicles)
        {
            Console.WriteLine("\n--- Commencing Vehicle diagnostics ---");
            foreach (var v in allVehicles)
            {
                Console.WriteLine($"-- Testing {v.ModelName} --");
                v.Drive();
                v.Refuel();
            }
        }

    }

}
