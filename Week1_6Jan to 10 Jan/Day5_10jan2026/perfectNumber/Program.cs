using System.Collections.Specialized;

namespace perfectNumber
{
    internal class Program
    {
        public int PerfectNumber()
        {
            Console.WriteLine("Enter Number Please");
            int number = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            if(number < 0)
            {
                output = -2;
            }
            else
            {
				int divisorSum = 0;

				for (int i = 1; i < number; i++)
				{
					if (number % i == 0)
					{
						divisorSum += i;
					}
				}

				if (divisorSum == number)
				{
					output = 1;
				}
			}

            return output;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int answer = obj.PerfectNumber();
            Console.Write(answer);
        }
    }
}
