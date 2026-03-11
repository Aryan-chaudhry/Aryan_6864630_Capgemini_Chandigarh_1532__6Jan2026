using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LuckyNumber
{
    internal class luckyNumber
    {
        bool NotPrime(int number)
        {
            if (number < 0) return false;

            for(int i=2; i<number; i++)
            {
                if(number%i == 0)
                {
                    return true; // because this is prime;
                }
            }
            return false;
        }

        public int Sum(int number)
        {
            int tempNumber = number;
            int sum = 0;

            while(tempNumber > 0)
            {
                int digit = tempNumber % 10;
                sum += digit;
                tempNumber /= 10;
            }

            return sum;
        }

        public int FindLuckyNumber(int m, int n)
        {
            int luckyNumberCount = 0;

            for(int i=m; i<=n; i++)
            {
                if (NotPrime(i) == true)
                {
                    if(Sum(i*i) == Sum(i) * Sum(i))
                    {
                        luckyNumberCount++;
                    }
                }
            }
            return luckyNumberCount;
        }
    }
}
