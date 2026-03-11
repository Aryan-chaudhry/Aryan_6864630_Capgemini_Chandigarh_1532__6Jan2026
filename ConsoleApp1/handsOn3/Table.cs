using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.handsOn3
{
    internal class Table
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the Number : ");
            int Number = int.Parse(Console.ReadLine());

            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(Number + " x " + i + " = " + Number * i);
            }
        }
    }
}
