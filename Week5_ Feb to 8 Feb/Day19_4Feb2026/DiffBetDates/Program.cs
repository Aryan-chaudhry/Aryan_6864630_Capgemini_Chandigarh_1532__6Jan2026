namespace DiffBetDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            Console.WriteLine(UserProgramCode.FindDiff(input1, input2));
        }
    }
}
