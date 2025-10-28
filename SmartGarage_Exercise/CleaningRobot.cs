using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{

	
	public class CleaningRobot : Imoveable
	{
	
		public string SerialNumber
		{
			get; set;
		}
		public int BatteryPercentage
		{
			get; private set;
		}
		public CleaningRobot(string serial, int battery)
		{
			SerialNumber = serial;
			BatteryPercentage = Math.Clamp(battery, 0, 100);
		}
		public void StartCleaning()
		{
			if (BatteryPercentage > 20)
			{
				BatteryPercentage -= 20;
				Console.WriteLine($"Robot {SerialNumber} is cleaning 'Zzzzz'. Battery: {BatteryPercentage}%");
			}
			else
			{
				Console.WriteLine($"Robot {SerialNumber} cannot clean. Battery low.");
			}
		}
		public void ChargeBattery()
		{
			Console.WriteLine($"Charging {SerialNumber}...");
			BatteryPercentage = 100;
		}


		public void MoveLeft()
		{
			Console.WriteLine($"Robot {SerialNumber} spins left.");
		}

        public void MoveRight()
        {
			Console.WriteLine($"Robot {SerialNumber} spins right.");
		}
	}
}
