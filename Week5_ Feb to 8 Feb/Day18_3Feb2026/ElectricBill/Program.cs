namespace ElectricBill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int input3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(UserProgramCode.Calculate(input1, input2, input3));
        }
    }
}
