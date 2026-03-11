namespace Factorial
{
    internal class Program
    {
        int GetFactorial()
        {
            Console.Write("Enter Number Please : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int answer = 1;

            if(number < 0)
            {
                answer = -1;
            }
            else if(number > 7)
            {
                answer = -2;
            }
            else
            {
                for(int i=1; i<=number; i++)
                {
                    answer *= i;
                }
            }
            return answer;
        }

        static void Main(string[] args)
        {
            Program factorial = new Program();
            int answer = factorial.GetFactorial();
            Console.WriteLine(answer);
        }
    }
}
