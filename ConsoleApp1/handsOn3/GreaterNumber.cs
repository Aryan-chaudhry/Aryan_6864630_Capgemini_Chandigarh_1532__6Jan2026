using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.handOn4;

namespace ConsoleApp1.handsOn3
{
    internal class GreaterNumber
    {
        void FindGreaterNumber(int no1, int no2, int no3)
        {
            if(no1 >= no2 && no1 >= no3)
            {
                Console.WriteLine(no1 + " is greater");
            }
            else if(no2 >= no3 && no2 >= no1)
            {
                Console.WriteLine(no2 + " is greater");
            }
            else
            {
                Console.WriteLine(no3 + " is greater");
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int no1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            int no2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third Number");
            int no3 = int.Parse(Console.ReadLine());


			GreaterNumber p1 = new GreaterNumber();
            p1.FindGreaterNumber(no1, no2, no3);
        }
    }
}
