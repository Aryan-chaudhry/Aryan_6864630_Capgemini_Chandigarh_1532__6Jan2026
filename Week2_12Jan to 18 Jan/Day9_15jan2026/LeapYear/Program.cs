namespace LeapYear
{
    internal class Program
    {
        public int CheckLeapYear()
        {
            Console.Write("Enter year you want to check : ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            if(input1 < 0)
            {
                output = -1;
            }

            return output = input1 % 4 == 0 && input1 % 100 != 0 ? 1 : -2;
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            int output = obj.CheckLeapYear();
            Console.Write(output);
        }
    }
}
