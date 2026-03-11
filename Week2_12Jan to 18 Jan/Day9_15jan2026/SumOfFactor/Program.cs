namespace SumOfFactor
{
    internal class Program
    {
        public int FindSumOfFactor()
        {
            Console.Write("Enter Number : ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the limit : ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            if(input1 < 0)
            {
                output = -1;
                return output;
            }

            if(input2 > 32676)
            {
                output = -2;
                return output;
            }

            int sum = 0;
            int index = input1;

            while(index <= input2)
            {
                sum += index;
                index += input1;
            }

            return output = sum;
        }

		static void Main(string[] args)
        {
            Program obj = new Program();
            int output = obj.FindSumOfFactor();
            Console.Write(output);
        }
    }
}
