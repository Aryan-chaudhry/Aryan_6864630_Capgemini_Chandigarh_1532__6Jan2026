using System;

namespace VehicleRentalSystem
{
	abstract class Vehicle
	{
		public int VehicleId { get; private set; }
		public string Brand { get; private set; }
		public bool IsAvailable { get; set; }

		protected Vehicle(int vehicleId, string brand)
		{
			VehicleId = vehicleId;
			Brand = brand;
			IsAvailable = true;
		}

		public abstract double CalculateRent(int days);

		public override string ToString()
		{
			return $"ID: {VehicleId}, Brand: {Brand}, Available: {IsAvailable}";
		}
	}
}
