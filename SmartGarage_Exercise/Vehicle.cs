using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    public abstract class Vehicle
    {
        public string ModelName{get; set;}

 
        public Vehicle(string model)
        {
            ModelName = model;
        }

        public abstract void Drive();
        public abstract void Refuel();
       
    }
}
