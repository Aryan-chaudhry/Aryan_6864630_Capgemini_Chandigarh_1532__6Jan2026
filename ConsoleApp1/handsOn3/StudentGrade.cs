using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1.handsOn3
{
    internal class StudentGrade
    {

        void GetGrade(int sub1, int sub2, int sub3)
        {
            int marksObtained = sub1 + sub2 + sub3;

            int percentage = (marksObtained / 3);

            if(percentage >= 95)
            {
                Console.WriteLine("A+");
            }
            else if(percentage >= 90 && percentage < 95)
            {
                Console.WriteLine("A");
            }
            else if(percentage >= 85 && percentage < 90)
            {
                Console.WriteLine("B+");
            }
            else if(percentage >= 80 && percentage < 85)
            {
                Console.WriteLine("B");
            }
            else if(percentage >= 70 && percentage < 80)
            {
                Console.WriteLine("C");
            }
            else if(percentage >= 60 && percentage < 70)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("Oops Fail");
            }
        }

        public static void Main(string[] args)
        {
            int physics, chemistry, math;

            Console.WriteLine("Enter Physics Marks");
            physics = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Chemistry Marks");
            chemistry = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Maths Marks");
            math = int.Parse(Console.ReadLine());

            StudentGrade p2 = new StudentGrade();
            p2.GetGrade(physics, chemistry, math);
        }
    }
}
