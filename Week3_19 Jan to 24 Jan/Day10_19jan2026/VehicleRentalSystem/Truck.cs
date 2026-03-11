using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRentalSystem
{
    internal class Truck:Vehicle
    {
		private const double RentPerDay = 3000;

		public Truck(int id, string brand) : base(id, brand) { }

		public override double CalculateRent(int days)
		{
			return days * RentPerDay;
		}
	}
}
