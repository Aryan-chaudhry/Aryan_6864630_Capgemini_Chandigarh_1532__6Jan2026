using System.Diagnostics.CodeAnalysis;

namespace StudentGradingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> st = new List<Student>
            {
                new Student {Name = "Aryan", Uid = "16750", grade = 80},
                new Student {Name = "Ayush", Uid = "16751", grade = 90},
                new Student {Name = "Avinash", Uid = "16752", grade = 95}
            };

            // display all Studets
            var allStudents = from student in st
                              select student;

            foreach(var item in allStudents)
            {
                Console.WriteLine(item.Name + "   " + item.Uid + "   " + item.grade);
            }
            Console.WriteLine();

            // compute Average Grade
            double Average = st.Average(st => st.grade);
            Console.Write("Average Grade of students : " + Average);

            // Identify student at risk
            Console.WriteLine("Enter the target Grade :  ");
            int targetGrade = Convert.ToInt32(Console.ReadLine());

            var riskStudents = from student in st
                                 where student.grade < targetGrade
                                 select student.Name;

            Console.WriteLine("\n Students at risk : \n");
            foreach(var student in riskStudents)
            {
                Console.WriteLine(student);
            }
			Console.WriteLine();

			// update studentGrade

			foreach (var item in st)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Uid);
                Console.WriteLine(item.grade);

                Console.WriteLine("\n Enter new Grade of Student : ");
                int newGrade = Convert.ToInt32(Console.ReadLine());

                item.grade = newGrade;

                Console.WriteLine("Grade Updated Successfully");
            }
			Console.WriteLine();

			// Identify student at risk
			Console.WriteLine("Enter the target Grade :  ");
			int newtargetGrade = Convert.ToInt32(Console.ReadLine());

			var newriskStudents = from student in st
							   where student.grade < newtargetGrade
							   select student.Name;

			Console.WriteLine("\n Students at risk : \n");
			foreach (var student in newriskStudents)
			{
				Console.WriteLine(student);
			}

		}
    }
}
