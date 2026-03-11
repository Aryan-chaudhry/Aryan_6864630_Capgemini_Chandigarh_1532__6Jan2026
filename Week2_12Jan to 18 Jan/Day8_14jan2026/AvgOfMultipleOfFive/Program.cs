namespace AverageOfFive
{
    internal class Program
    {
        public double FindAvgOfFive()
        {
            Console.Write("Enter Number Please : ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            double output = 0;

            if(input1 < 0)
            {
                output = -1;
                return output;
            }
            else if(input1 >= 500)
            {
                output = -2;
                return output;
            }

                double sum = 0, count = 0;

            for(int i=1; i<=input1; i++)
            {
                if(i%5 == 0)
                {
                    sum += i;
                    count++;
                }
            }

            output = sum / count;
            return output;
        }

		static void Main(string[] args)
        {
            Program obj = new Program();
            double output = obj.FindAvgOfFive();
            Console.Write(output);
        }
    }
}
