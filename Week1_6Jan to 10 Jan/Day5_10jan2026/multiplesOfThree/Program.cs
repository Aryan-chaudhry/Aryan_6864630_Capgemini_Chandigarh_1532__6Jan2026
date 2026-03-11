namespace multiplesOfThree
{
    internal class Program
    {
        public int CountMultipleOfThree()
        {
            Console.WriteLine("Enter the size of array : ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            if(input2 < 0)
            {
                output = -2;
            }
            else
            {
				int[] input1 = new int[input2];

				// take input of array
				for (int i=0; i< input2; i++)
                {
					input1[i] = Convert.ToInt32(Console.ReadLine());
                }

                // check if negative number present store -1 else count multiple of 3

                bool negativeElement = false;

                foreach(int no in input1)
                {
                    if(no < 0)
                    {
                        negativeElement = true;
                        break;
                    }
                }

                if (negativeElement)
                {
                    output = -1;
                }
                else
                {
                    foreach(int no in input1)
                    {
                        if(no%3 == 0)
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
            int output = obj.CountMultipleOfThree();
            Console.WriteLine(output);
        }
    }
}
