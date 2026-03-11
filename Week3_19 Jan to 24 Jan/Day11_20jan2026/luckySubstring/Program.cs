namespace luckySubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            string output = FindLuckySubstring.findLuckySubstring(str, N);
            Console.WriteLine(output);
        }
    }
}
