using System.Collections.Generic;

namespace UniversityManagement
{
	class Professor : Person
	{
		public int ProfessorId { get; private set; }
		private List<Course> assignedCourses = new List<Course>();

		public Professor(int id, string name, string email)
			: base(name, email)
		{
			ProfessorId = id;
		}

		public void AssignCourse(Course course)
		{
			assignedCourses.Add(course);
			course.AssignProfessor(this);
		}

		public override void ShowProfile()
		{
			System.Console.WriteLine($"Professor: {GetName()} (ID: {ProfessorId})");
			System.Console.WriteLine("Assigned Courses:");
			foreach (var c in assignedCourses)
				System.Console.WriteLine($" - {c.CourseName}");
		}
	}
}
