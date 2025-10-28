using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{

	public class Motorcycle: Vehicle, IChargeable, Imoveable
	{
        public string ModelName { get; set; }
        public int FuelPercentage
        {
            get; private set;
        }


        public Motorcycle(string model, int fuel):base(model) {
            FuelPercentage = Math.Clamp(fuel, 0, 100);
        }
		
		public override void Drive()
		{
			if (FuelPercentage > 5)
			{
				FuelPercentage -= 5;
				Console.WriteLine($"The motorcycle {ModelName} goes 'Neeeeow'. Fuel left: {FuelPercentage}%");
			}
			else
			{
				Console.WriteLine($"The motorcycle {ModelName} cannot drive. No fuel.");
			}
		}

		public void MoveLeft()
		{
			Console.WriteLine($"Motorcycle {ModelName} leans left.");
		}
		public void MoveRight()
		{
			Console.WriteLine($"Motorcycle {ModelName} leans right.");
		}
        public override void Refuel()
        {
            Console.WriteLine($"Refueling {ModelName}...");
            FuelPercentage = 100;
        }
    }

}
