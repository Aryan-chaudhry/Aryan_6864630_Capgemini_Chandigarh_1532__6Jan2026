namespace replaceArray
{
    internal class Program
    {
        public void ReplaceArray()
        {
            Console.Write("Enter size of Array : ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            
            if(input2 < 0)
            {
                Console.WriteLine("Size can't be negative");
                return;
            }
            else
            {
                int[] input1 = new int[input2];

                // take input of array
                for(int i=0; i<input2; i++)
                {
                    input1[i] = Convert.ToInt32(Console.ReadLine());
                }

                int st = 0;
                int end = input1.Length - 1;

                while(st <= end)
                {
                    int temp = input1[st];
                    input1[st] = input1[end];
                    input1[end] = temp;
                    st++;
                    end--;
                }

                // if contain negative element store -1 at first position
                bool isNegative = false;

                foreach(int number in input1)
                {
                    if(number < 0)
                    {
                        isNegative = true;
                        break;
                    }
                }

                input1[0] = isNegative ? -1 : input1[0];

                // if size is even store -3 at first position

                input1[0] = input1.Length % 2 == 0 ? -3 : input1[0];

				// printing the array
				foreach (int number in input1)
				{
					Console.Write(number + " ");
				}
			}

            
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.ReplaceArray();
        }
    }
}
