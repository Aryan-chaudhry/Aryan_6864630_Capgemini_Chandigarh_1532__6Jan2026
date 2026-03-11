namespace evenDigitSum
{
    internal class Program
    {
        public int CalculateEvenSum()
        {
            Console.WriteLine("Enter the Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            if(number < 0)
            {
                output = -1;
            }
            else if(number > 32767)
            {
                output = -2;
            }
            else
            {
                while(number > 0)
                {
                    int digit = number % 10;
                    output += digit % 2 == 0 ? digit : 0;
                    number /= 10;
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int answer = obj.CalculateEvenSum();
            Console.WriteLine(answer);
        }
    }
}
