using System;

namespace UniversityManagement
{
	abstract class Person
	{
		private string name;
		private string email;

		protected Person(string name, string email)
		{
			this.name = name;
			this.email = email;
		}

		public string GetName() => name;
		public string GetEmail() => email;

		public abstract void ShowProfile();
	}
}
