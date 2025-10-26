using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
	/// <summary>
	/// מייצג אופנוע בעל מנוע דלק.
	/// </summary>
	public class Motorcycle
	{
		/// <summary>
		/// שם הדגם של האופנוע.
		/// </summary>
		public string ModelName
		{
			get; set;
		}

		/// <summary>
		/// אחוז הדלק הנוכחי (בין 0 ל-100).
		/// </summary>
		public int FuelPercentage
		{
			get; private set;
		}

		/// <summary>
		/// בנאי ליצירת אופנוע חדש.
		/// </summary>
		/// <param name="model">שם דגם האופנוע.</param>
		/// <param name="fuel">כמות הדלק ההתחלתית.</param>
		public Motorcycle(string model, int fuel)
		{
			ModelName = model;
			// Math.Clamp: מבטיח שהדלק יהיה תמיד בטווח 0-100.
			FuelPercentage = Math.Clamp(fuel, 0, 100);
		}

		/// <summary>
		/// מבצע פעולת נסיעה הצורכת דלק (בצורה שונה ממכונית).
		/// </summary>
		public void Drive()
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

		/// <summary>
		/// מתדלק את האופנוע למקסימום.
		/// </summary>
		public void Refuel()
		{
			Console.WriteLine($"Refueling {ModelName}...");
			FuelPercentage = 100;
		}

		/// <summary>
		/// מזיז את האופנוע שמאלה.
		/// </summary>
		public void MoveLeft()
		{
			Console.WriteLine($"Motorcycle {ModelName} leans left.");
		}

		/// <summary>
		/// מזיז את האופנוע ימינה.
		/// </summary>
		public void MoveRight()
		{
			Console.WriteLine($"Motorcycle {ModelName} leans right.");
		}
	}

}
