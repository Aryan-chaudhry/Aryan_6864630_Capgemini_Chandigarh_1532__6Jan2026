namespace UniversityManagement
{
	class Course
	{
		public int CourseId { get; private set; }
		public string CourseName { get; private set; }
		public Professor AssignedProfessor { get; private set; }

		public Course(int id, string name)
		{
			CourseId = id;
			CourseName = name;
		}

		public void AssignProfessor(Professor professor)
		{
			AssignedProfessor = professor;
		}
	}
}
