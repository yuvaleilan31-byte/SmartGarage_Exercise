using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise;
	

		public class Car: Vehicle, IChargeable, Imoveable
		{
			public string ModelName { get; set; }
			public int FuelPercentage
			{
				get; private set;
			}

			public Car(string model, int fuel): base(model){
					FuelPercentage = Math.Clamp(fuel, 0, 100);
				}
			


			public override void Drive()
			{
				if (FuelPercentage > 10)
				{
					FuelPercentage -= 10;
					Console.WriteLine($"The car {ModelName} goes 'Vroom Vroom'. Fuel left: {FuelPercentage}%");
				}
				else
				{
					Console.WriteLine($"The car {ModelName} cannot drive. No fuel.");
				}
			}

			public override void Refuel()
			{ 
				Console.WriteLine($"Refueling {ModelName}...");
				FuelPercentage = 100;
			}

			public void MoveLeft()
			{
				Console.WriteLine($"Car {ModelName} turns left.");
			}
			public void MoveRight()
			{
				Console.WriteLine($"Car {ModelName} turns right.");
			}
		}

	
