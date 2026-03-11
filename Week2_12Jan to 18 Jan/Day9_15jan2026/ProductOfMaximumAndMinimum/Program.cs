namespace ProductOfMaximumAndMinimum
{
    internal class Program
    {
        public int FindProductOfMaxAndMin()
        {
            Console.Write("Enter the size of array : ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            if(input2 < 0)
            {
                output = -2;
                return output;
            }

            int[] input1 = new int[input2];

            // taking input of array
            for(int i=0; i<input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }

            // if negative element store -1
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
                output = -1;
                return output;
            }

            // find maximum Element
            int maxi = int.MinValue;
            int mini = int.MaxValue;

            foreach(int number in input1)
            {
                maxi = Math.Max(maxi, number);
                mini = Math.Min(mini, number);
            }
            return output = maxi * mini;            
        }

		static void Main(string[] args)
        {
            Program obj = new Program();
            int output = obj.FindProductOfMaxAndMin();
            Console.Write(output);
        }
    }
}
