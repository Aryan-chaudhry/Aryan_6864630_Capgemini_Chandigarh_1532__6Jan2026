using System.Text.RegularExpressions;

namespace DigitSumInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array : ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            string[] input2 = new string[input1];
            bool isSpecialChar = false;

            for(int i=0; i<input1; i++)
            {
                string str = Console.ReadLine();

                // use regex to check special character
                bool pattern = Regex.IsMatch(str, @"^[a-zA-Z0-9]+$");

                if(pattern == false)
                {
                    isSpecialChar = true;
                    break;
                }
                else
                {
                    input2[i] = str;
                }

            }

            if (isSpecialChar)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(UserProgramCode.SumOfDigit(input2));
            }
        }
    }
}
