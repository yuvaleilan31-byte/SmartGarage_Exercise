using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    public class Drone: Imoveable, IChargeable
    {
        
        public int BatteryPercentage { get; set; }

        public String ModelName {  get; set; }
        public Drone(String model, int battery) {
            BatteryPercentage = Math.Clamp(battery, 0, 100);
            ModelName = model;

        }
        public void Fly()
        {
            Console.WriteLine("drone id flying");
        }

        public void MoveLeft()
        {
            Console.WriteLine("Drone turns left.");
        }
        public void MoveRight()
        {
            Console.WriteLine("Drone turns right.");
        }

        public void Refuel()
        {
            Console.WriteLine($"Drone charged");
            BatteryPercentage = 100;
        }

    }
}
