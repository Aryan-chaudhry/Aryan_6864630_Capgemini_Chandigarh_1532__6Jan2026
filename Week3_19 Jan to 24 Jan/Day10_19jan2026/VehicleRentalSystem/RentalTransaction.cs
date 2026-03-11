using System;

namespace VehicleRentalSystem
{
	class RentalTransaction
	{
		public Customer Customer { get; private set; }
		public Vehicle Vehicle { get; private set; }
		public int Days { get; private set; }
		public double TotalAmount { get; private set; }

		public RentalTransaction(Customer customer, Vehicle vehicle, int days)
		{
			if (!vehicle.IsAvailable)
				throw new Exception("Vehicle not available!");

			Customer = customer;
			Vehicle = vehicle;
			Days = days;

			Vehicle.IsAvailable = false;
			TotalAmount = vehicle.CalculateRent(days);
		}

		public void ReturnVehicle()
		{
			Vehicle.IsAvailable = true;
		}
	}
}
