namespace LuckyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1, input2;
            input1 = Convert.ToInt32(Console.ReadLine());
            input2 = Convert.ToInt32(Console.ReadLine());
            luckyNumber obj = new luckyNumber();
            int output = obj.FindLuckyNumber(input1, input2);
            Console.Write(output);
        }
    }
}
