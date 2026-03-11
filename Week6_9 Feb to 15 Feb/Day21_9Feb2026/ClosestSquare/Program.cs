namespace ClosestSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(UserProgramCode.Solve(number));
        }
    }
}
