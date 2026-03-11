using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRentalSystem
{
    internal class Bike:Vehicle
    {
		private const double RentPerDay = 500;

		public Bike(int id, string brand) : base(id, brand) { }

		public override double CalculateRent(int days)
		{
			return days * RentPerDay;
		}
	}
}
