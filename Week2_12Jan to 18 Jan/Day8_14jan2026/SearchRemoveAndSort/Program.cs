using System.ComponentModel;

namespace SearchRemoveAndSort
{
    internal class Program
    {
        public int[] Solve()
        {
            Console.Write("Enter the size of array : ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int[] input1;
            int[] output;

            if(input2 < 0)
            {
				output = new int[1];
				output[0] = -2;
                return output;
            }
            else
            {
				input1 = new int[input2];

                bool isNegativeElement = false;
                for(int i=0; i<input2; i++)
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    isNegativeElement = number < 0 ? true : false;
                    input1[i] = number;
                }

                if (isNegativeElement)
                {
                    output = new int[1];
                    output[0] = -1;
                    return output;
                }
                
                    output = new int[input2];

                    Console.Write("Enter target value : ");
                    int input3 = Convert.ToInt32(Console.ReadLine());
                    int index = 0;
                    bool isTargetPrent = false;

                    foreach(int number in input1)
                    {
                        if(number != input3)
                        {
                            output[index++] = number;
                        }
                        else
                        {
                            isTargetPrent = true;
                        }
                    }


                if (isTargetPrent)
                {
                    Array.Resize(ref output, index);
                    output.Sort();
                }
                else
                {
                    Array.Resize(ref output, 1);
                    output[0] = -3;
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            var output = obj.Solve();

            foreach(int number in output)
            {
                Console.Write(number + " ");
            }
        }
    }
}
