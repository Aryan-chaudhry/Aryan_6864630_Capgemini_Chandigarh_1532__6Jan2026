namespace productOfDigit
{
    internal class Program
    {
        public int FindProductOfDigit()
        {
            Console.WriteLine("Enter a Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            if(number < 0)
            {
                output = -1;
            }
            else if(number%3 == 0 || number%5 == 0)
            {
                output = -2;
            }
            else
            {
                int product = 1;

                while(number > 0)
                {
                    int digit = number % 10;
                    product *= digit;
                    number /= 10;
                }

                if(product % 3 == 0 || product % 5 == 0)
                {
                    output = 1;
                }
            }
            return output;
        }

		static void Main(string[] args)
        {
            Program obj = new Program();
            int output = obj.FindProductOfDigit();
            Console.WriteLine(output);
        }
    }
}
