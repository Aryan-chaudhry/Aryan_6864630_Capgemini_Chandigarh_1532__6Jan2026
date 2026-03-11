namespace SumOfSquareOfOddDigit
{
    internal class Program
    {
        public int FindSumOfSqaureOfOddDigit()
        {
            Console.Write("Enter number please ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            if(input1 < 0)
            {
                output = -1; ;
                return output;
            }


            while(input1 > 0)
            {
                int digit = input1 % 10;

                if(digit % 2 != 0)
                {
                    output += (int)Math.Pow(digit, 2);
                }

                input1 /= 10;
            }

            return output;
        }

		static void Main(string[] args)
        {
            Program obj = new Program();
            int output = obj.FindSumOfSqaureOfOddDigit();
            Console.WriteLine(output);
        }
    }
}
