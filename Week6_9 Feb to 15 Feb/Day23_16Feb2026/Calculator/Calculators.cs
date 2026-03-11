using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Calculator
{
    public class Calculators
    {
        public int Add(int no1, int no2) => no1 + no2;

        public int Sub(int no1, int no2) => no1 - no2;

        public int Mul(int no1, int no2) => no1 * no2;

        public double Div(int no1, int no2)
        {
            if(no2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return (double)no1 / no2;
        }
    }
}
