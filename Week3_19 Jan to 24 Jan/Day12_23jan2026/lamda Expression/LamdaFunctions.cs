using System;
using System.Collections.Generic;
using System.Text;

namespace lamda_Expression
{
    internal static class LamdaFunctions
    {
        public static Func<int, int, int> Add = (num1, num2) => num1 + num2;
        public static Func<int, int, int> Sub = (num1, num2) => num1 - num2;
        public static Func<int, bool> Odd = (num1) => num1 % 2 == 0;  
    }
}
