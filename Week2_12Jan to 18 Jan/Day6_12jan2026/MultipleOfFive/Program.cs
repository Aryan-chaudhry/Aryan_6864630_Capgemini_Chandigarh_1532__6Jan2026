namespace MultipleOfFive
{
    internal class Program
    {
        public double FindAverageOfFive()
        {
            Console.Write("Enter the Number : ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            double output = 0;

            if(input2 < 0)
            {
                output = -2;
            }
            else
            {
                int[] input1 = new int[input2];

                bool isNegativeElement = false;

                for(int i=0; i<input2; i++)
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    if(number < 0)
                    {
                        isNegativeElement = true;
                    }
                    input1[i] = number;
                }

                if (isNegativeElement)
                {
                    output = -2;
                }
                else
                {
                    int sumOfFive = 0;
                    int NumberOfFive = 0;

                    foreach(int number in input1)
                    {
                        if(number%5 == 0)
                        {
                            sumOfFive += number;
                            NumberOfFive++;
                        }
                    }

                    output = (double)sumOfFive / NumberOfFive;
                }
            }
            return output;            
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            double output = obj.FindAverageOfFive();
            Console.WriteLine(output);
        }
    }
}
