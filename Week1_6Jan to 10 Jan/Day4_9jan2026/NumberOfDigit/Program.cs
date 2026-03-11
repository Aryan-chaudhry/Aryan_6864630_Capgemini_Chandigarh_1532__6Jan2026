namespace NumberOfDigit
{
    internal class Program
    {
        public int FindNumberOfDigit()
        {
            Console.Write("Enter the Number please : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            if(number < 0)
            {
                output = -1;
            }
            else
            {
                int length = 0;
                while(number > 0)
                {
                    length++;
                    number /= 10;
                }
                output = length;
            }
            return output;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int answer = obj.FindNumberOfDigit();
            Console.WriteLine(answer);
        }
    }
}
