namespace GuessPassword
{
    internal class Program
    {
        public int GuessThePassword()
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
            // take inout
            for(int i=0; i<input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
                if (input1[i] < 0)
                {
                    output = -1;
                    return output;
                }
            }

            int evenSum = 0, oddSum = 0;

            foreach(int number in input1)
            {
                if(number%2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }

            int passWord = (evenSum + oddSum) / 2;
            return output = passWord;

        }

		static void Main(string[] args)
        {
            Program obj = new Program();
            int output = obj.GuessThePassword();
            Console.Write(output);
        }
    }
}
