using System.Collections.Generic;

namespace UniversityManagement
{
	class Student : Person
	{
		public int StudentId { get; private set; }
		private List<Course> courses = new List<Course>();

		public Student(int id, string name, string email)
			: base(name, email)
		{
			StudentId = id;
		}

		public void RegisterCourse(Course course)
		{
			courses.Add(course);
		}

		public override void ShowProfile()
		{
			System.Console.WriteLine($"Student: {GetName()} (ID: {StudentId})");
			System.Console.WriteLine("Enrolled Courses:");
			foreach (var c in courses)
				System.Console.WriteLine($" - {c.CourseName}");
		}
	}
}
