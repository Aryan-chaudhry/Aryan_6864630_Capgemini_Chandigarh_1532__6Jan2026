using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.handsOn2
{
    internal class Array
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[4];

            for(int i=0; i<=3; i++)
            {
                Console.WriteLine("Enter the value at index : " + i);
                int value = int.Parse(Console.ReadLine());
                arr[i] = value;
            }

            foreach(int no in arr)
            {
                if (no >= 20)
                {
                    Console.Write(no + " ");
                }
            }
        }
    }
}
