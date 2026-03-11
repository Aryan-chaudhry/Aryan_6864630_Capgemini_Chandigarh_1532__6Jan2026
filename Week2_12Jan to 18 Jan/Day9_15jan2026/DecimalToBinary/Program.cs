namespace DecimalToBinary
{
    internal class Program
    {
        public int getLength(int number)
        {
            int length = 0;
            int temp = number;

            while(temp  >  0)
            {
                length++;
                temp /= 2;
            }

            return length;
        }

		public int[] ConvertDecimalToBinary()
        {
            Console.Write("Enter the number : ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            
            if(input1 < 0)
            {
                return [-1];
            }

            int length = getLength(input1);
            int[] output = new int[length];
            int index = length-1;

            while(input1 > 0)
            {
                int digit = input1 % 2;
                output[index--] = digit;
                input1 /= 2;
            }


            return output;
        }

		static void Main(string[] args)
        {
            Program obj = new Program();
            int[] output = obj.ConvertDecimalToBinary();
            foreach(int number in output)
            {
                Console.Write(number + " ");
            }
        }
    }
}
