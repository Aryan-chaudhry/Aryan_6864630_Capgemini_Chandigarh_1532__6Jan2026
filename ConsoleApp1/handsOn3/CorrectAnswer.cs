using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.handsOn3
{
    internal class CorrectAnswer
    {
        void Question()
        {
            Console.WriteLine("What is the correct way to declare a variable to store an integer value in C#?");

            Console.WriteLine("a. int 1x=10;");
            Console.WriteLine("b. int x=10;");
            Console.WriteLine("c. float x=10.Of");
            Console.WriteLine("d. string x='10'");

            char ch = char.Parse(Console.ReadLine());  

            if(ch == 'b')
            {
                Console.WriteLine("Congratulations! Correct Ans.");
            }
            else
            {
                Console.WriteLine("Incorrect Answer!"); 
            }

        }
        static void Main(string[] args)
        {
            CorrectAnswer p4 = new CorrectAnswer();
            p4.Question();
        }
    }
}
