using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRentalSystem
{
    internal class Car:Vehicle
    {
		private const double RentPerDay = 1500;

		public Car(int id, string brand) : base(id, brand) { }

		public override double CalculateRent(int days)
		{
			return days * RentPerDay;
		}
	}
}
