using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquire_vehicle
{
    internal class Motorcycle:Vehicle,IVehicle,IDrift
    {
        public Motorcycle():base()
        {
                
        }

        public string StartVehicle()
        {
            return "Your motorcycle is ready to ride";
        }

        public string EstimateCost()
        {
            int cost;
            switch (class_vehicle)
            {
                case "A":
                     cost = 100000;
                    break;
                case "B":
                     cost = 50000;
                    break;
                case "S":
                     cost = 200000;
                    break;
                default:
                    throw new InvalidOperationException("Invalid vehicle type");
            }

            return "The cost of your motorcycle is: "+"$"+cost;
        }
        public string Drift()
        {
            return "I'm drifting in the curners";
        }
    }
}
