using System;
using System.Collections.Generic;

namespace VehicleRentalSystem
{
	class Program
	{
		static void Main()
		{
			List<Vehicle> vehicles = new List<Vehicle>
			{
				new Car(1, "Honda"),
				new Bike(2, "Yamaha"),
				new Truck(3, "Tata")
			};

			Customer customer = new Customer(101, "Aryan");

			Console.WriteLine("Available Vehicles:");
			foreach (var v in vehicles)
				Console.WriteLine(v);

			Console.WriteLine("\nRenting a Car for 3 days...");
			RentalTransaction rental = new RentalTransaction(customer, vehicles[0], 3);

			Console.WriteLine($"Total Rent: ₹{rental.TotalAmount}");

			Console.WriteLine("\nReturning Vehicle...");
			rental.ReturnVehicle();

			Console.WriteLine("Vehicle Returned Successfully!");
		}
	}
}
