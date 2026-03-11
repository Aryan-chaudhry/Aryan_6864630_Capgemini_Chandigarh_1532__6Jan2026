using System.Collections.Specialized;
using System.Numerics;

namespace BinaryToDecimal
{
    internal class Program
    {
        public bool IsBinaryNumber(int number)
        {
            int temp = number;
            
            while(temp > 0)
            {
                int digit = temp % 10;
                if (digit != 0 && digit != 1) return false;
                temp /= 10;
            }

            return true;
        }

        public int GetLength(int number)
        {
            int length = 0;
            int temp = number;

            while(temp > 0)
            {
                length++;
                temp /= 10;
            }

            return length;
        }
        public int ConvertToDecimal()
        {
            Console.Write("Enter Number please : ");
            int input = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            if (IsBinaryNumber(input) == false)
            {
                output = -2;
                return output;
            }

			if (input > 11111)
			{
				output = -1;
				return output;
			}

            int length = GetLength(input);

            int decimalNumber = 0;
            int trackPower = 0;


            while(input > 0)
            {
                int digit = input % 10;
                decimalNumber += digit * (int)Math.Pow(2, trackPower);
                trackPower += 1;
                input /= 10;
            }

            return output = decimalNumber;
		}
        static void Main(string[] args)
        {
            Program obj = new Program();
            int output = obj.ConvertToDecimal();
            Console.Write(output);
        }
    }
}
