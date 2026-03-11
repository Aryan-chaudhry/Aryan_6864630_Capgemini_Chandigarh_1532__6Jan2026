using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.handsOn3
{
    internal class KeyPress
    {
		void DetectMyKey(string key)
		{
			if (key[0] >= '0' && key[0] <= '9')
			{
				Console.Write("You Enter key " + key);
			}
			else
			{
				Console.Write("Key you Enter is not allowed");
			}
		}

		static void Main(string[] args)
        {
            Console.Write("Enter Key : ");
			string key = Console.ReadLine();

            KeyPress p3 = new KeyPress();
            p3.DetectMyKey(key);
        }
    }
}
