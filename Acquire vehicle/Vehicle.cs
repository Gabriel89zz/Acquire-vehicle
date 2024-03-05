using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquire_vehicle
{
    abstract class Vehicle
    {
		protected string brand;

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		protected string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		protected string class_vehicle;

		public string Class_Vehicle
		{
			get { return class_vehicle; }
			set { class_vehicle = value; }
		}


		public Vehicle()
        {
			model = "";
			brand = "";
			class_vehicle = "";
        }
    }
}
