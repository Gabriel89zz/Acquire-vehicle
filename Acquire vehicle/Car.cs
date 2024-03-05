using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquire_vehicle
{
    internal class Car:Vehicle,IVehicle
    {
        public Car() : base()
        {

        }

        public string StartVehicle()
        {
            return "Your car is redy to drift";
        }

        public string EstimateCost()
        {
            int cost;
            switch (class_vehicle)
            {
                case "A":
                    cost = 500000;
                    break;
                case "B":
                    cost = 200000;
                    break;
                case "S":
                    cost = 1000000;
                    break;
                default:
                    throw new InvalidOperationException("Invalid vehicle type");
            }

            return "The cost of your car is: " +"$" + cost;
        }
    }
}
