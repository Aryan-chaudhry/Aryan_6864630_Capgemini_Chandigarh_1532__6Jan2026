namespace ArmStrong
{
    internal class Program
    {
        public int CheckArmstrong()
        {
            Console.WriteLine("Enter the Number Please");
            string numberInString = Console.ReadLine();
            int length = numberInString.Length;
            int number = Convert.ToInt32(numberInString);
            int output = 0;

            if(number < 0)
            {
                output = -1;
            }
            else if(length > 3)
            {
                output = -2;
            }
            else
            {
                int myOutput = 0;

                for(int i=0; i<length; i++)
                {
                    myOutput += (int)Math.Pow(numberInString[i] - '0', length);
                }
                if(myOutput == number)
                {
                    output = 1;
                }
                else
                {
                    output = 0;
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            Program armstrong = new Program();
            int answer = armstrong.CheckArmstrong();
            Console.WriteLine(answer);
        }
    }
}
