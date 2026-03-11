using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1.handsOn3
{
    internal class Pattern
    {

        static void Main(string[] args)
        {
            
            for(int i=0; i<=8; i++)
            {
                for(int j=1; j<=8-i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
