namespace AverageOfArray
{
    internal class Program
    {
        public float FindAvg()
        {
            Console.Write("Enter size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            if (size < 0)
            {
                output = -2;
            }
            else
            {
                // make array
                int[] arr = new int[size];

                // take input 
                for(int i=0; i<size; i++)
                {
                    Console.Write("Enter the number at index " + i + " : ");
                    int no = Convert.ToInt32(Console.ReadLine());
                    arr[i] = no;
                }

                // store -1 in output if no is negative
                bool isNegativeFound = false;

                foreach(int no in arr){
                    if(no < 0)
                    {
                        isNegativeFound = true;
                        break;
                    }
                }

                if (isNegativeFound)
                {
                    output = -1;
                }
                // find average
                else
                {
                    int evenSum = 0, oddSum = 0, average = 0;

                    foreach(int num in arr)
                    {
                        if(num%2 == 0)
                        {
                            evenSum += num;
                        }
                        else
                        {
                            oddSum += num;
                        }
                    }

                    output = (evenSum + oddSum) / 2;  
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            float answer = obj.FindAvg();
            Console.WriteLine(answer);
        }
    }
}
