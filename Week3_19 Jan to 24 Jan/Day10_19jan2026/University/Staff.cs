namespace UniversityManagement
{
	class Staff : Person
	{
		public int StaffId { get; private set; }
		public string Role { get; private set; }

		public Staff(int id, string name, string email, string role)
			: base(name, email)
		{
			StaffId = id;
			Role = role;
		}

		public override void ShowProfile()
		{
			System.Console.WriteLine($"Staff: {GetName()} (ID: {StaffId})");
			System.Console.WriteLine($"Role: {Role}");
		}
	}
}
