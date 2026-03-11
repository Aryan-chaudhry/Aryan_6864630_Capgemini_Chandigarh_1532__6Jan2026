namespace CountTargetElement
{
    internal class Program
    {
        public int CountElement()
        {
            Console.WriteLine("Enter the size of array : ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter target value : ");
            int input3 = Convert.ToInt32(Console.ReadLine());

            int output = 0;

            if(input2 < 0)
            {
                output = -2;
            }
            else
            {
                int[] input1 = new int[input2];
                // take input
                for(int i=0; i<input2; i++)
                {
                    input1[i] = Convert.ToInt32(Console.ReadLine());
                }

                // take -1 if negative
                bool isNegativeElement = false;

                foreach(int number in input1)
                {
                    if(number < 0)
                    {
                        isNegativeElement = true;
                        break;
                    }
                }

                if (isNegativeElement)
                {
                    output = -2;
                }
                else
                {
                    foreach(int number in input1)
                    {
                        if(number == input3)
                        {
                            output++;
                        }
                    }
                }
            }
            return output;
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            int output = obj.CountElement();
            Console.WriteLine(output);
        }
    }
}
