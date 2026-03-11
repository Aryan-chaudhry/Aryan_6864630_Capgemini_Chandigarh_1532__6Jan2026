namespace sumOfPrime
{
    internal class Program
    {
        bool isPrimeNumber(int num)
        {

            if (num <= 1) return false;

            bool isPrime = true;

            for(int i=2; i<num; i++)
            {
                if(num%i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
        public int FindPrimeSum()
        {
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            if(size < 0)
            {
                output = -2;
            }
            else
            {
                int[] input1 = new int[size];

                // take input
                for(int i=0; i<size; i++)
                {
                    input1[i] = Convert.ToInt32(Console.ReadLine());

                }

                // check if number is negative strore -1 in output
                bool isNegativeElement = false;

                foreach(int num in input1)
                {
                    if(num < 0)
                    {
                        isNegativeElement = true;
                        break;
                    }
                }

                if (isNegativeElement)
                {
                    output = -1;
                }
                else
                {
                    // find prime number
                    int primeNumberCount = 0;
                    int primeNumberSum = 0; 

                    foreach(int num in input1)
                    {
                        if (isPrimeNumber(num))
                        {
                            primeNumberCount++;
                            primeNumberSum += num;
                        }
                    }

                    // check if no primeNumber store -3 in output
                    if(primeNumberCount == 0)
                    {
                        output = -3;
                    }
                    else
                    {
                        output = primeNumberSum;
                    }
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int output = obj.FindPrimeSum();
            Console.WriteLine(output);
        }
    }
}
