using System;

namespace UniversityManagement
{
	class Program
	{
		static void Main()
		{
			Department csDept = new Department("Computer Science");

			Student s1 = new Student(1, "Aryan", "aryan@gmail.com");
			Professor p1 = new Professor(101, "Dr. Sharma", "sharma@uni.edu");
			Staff st1 = new Staff(201, "Ramesh", "ramesh@uni.edu", "Administrator");

			Course c1 = new Course(1001, "Data Structures");
			Course c2 = new Course(1002, "OOP with C#");

			s1.RegisterCourse(c1);
			s1.RegisterCourse(c2);

			p1.AssignCourse(c1);
			p1.AssignCourse(c2);

			csDept.AddMember(s1);
			csDept.AddMember(p1);
			csDept.AddMember(st1);

			csDept.ShowMembers();
		}
	}
}
