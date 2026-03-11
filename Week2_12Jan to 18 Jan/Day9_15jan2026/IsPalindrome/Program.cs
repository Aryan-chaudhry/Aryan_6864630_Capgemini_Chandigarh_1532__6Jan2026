namespace IsPalindrome
{
    internal class Program
    {
        public int IsNumberPalindrome()
        {
            Console.Write("Enter Number please : ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            if(input1 < 0)
            {
                output = -1;
                return output;
            }

            int temp = input1;
            while(temp > 0)
            {
                int digit = temp % 10;
                output = output * 10 + digit;
				temp /= 10;
            }

            return output == input1 ? 1 : -2;
        }





















		static void Main(string[] args)
        {
            Program obj = new Program();
            int output = obj.IsNumberPalindrome();
            Console.Write(output);
        }
    }
}
