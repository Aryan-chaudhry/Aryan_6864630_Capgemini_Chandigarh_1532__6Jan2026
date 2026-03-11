namespace SecondLargest
{
    internal class Program
    {
        public int FindSecondLargest()
        {
            Console.Write("Enter the size of array");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            if(input2 < 0)
            {
                output = -2;
                return output;
            }

            int[] input1 = new int[input2];

            // take input
            for(int index=0; index<input2; index++)
            {
                input1[index] = Convert.ToInt32(Console.ReadLine());
            }

            // if negative element return -1
            bool isNegativeElement = false;

            foreach(int number in input1)
            {
                if(number < 0)
                {
                    isNegativeElement = true; ;
                    break;
                }
            }

            if (isNegativeElement)
            {
                output = -1;
                return output;
            }

            // sort now 
            input1.Sort();

            // remove duplicate if present
            int i = 0, j = i + 1;
            while (j < input2)
            {
                if (input1[i] == input1[j])
                {
                    j++;
                }
                else
                {
                    i++;
                    input1[i] = input1[j];
                    j++;
                }
            }

            // till index <= i all are sorted and no duplicate present 
            if(i >= 1)
            {
                output = input1[i - 1];
            }
            else
            {
                output = -3;
            }

            return output;
        }

		static void Main(string[] args)
        {
            Program obj = new Program();
            int output = obj.FindSecondLargest();
            Console.Write(output);
        }
    }
}
