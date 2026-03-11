using System.Collections.Generic;

namespace UniversityManagement
{
	class Department
	{
		public string DepartmentName { get; private set; }
		private List<Person> members = new List<Person>();

		public Department(string name)
		{
			DepartmentName = name;
		}

		public void AddMember(Person person)
		{
			members.Add(person);
		}

		public void ShowMembers()
		{
			System.Console.WriteLine($"Department: {DepartmentName}");
			foreach (var member in members)
				member.ShowProfile();
		}
	}
}
