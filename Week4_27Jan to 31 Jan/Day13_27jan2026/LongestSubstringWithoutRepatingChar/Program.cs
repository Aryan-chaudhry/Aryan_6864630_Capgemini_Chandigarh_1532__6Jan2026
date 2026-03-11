namespace LongestSubstringWithoutRepatingChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int ans = Solve.solveProblem(str);
            Console.WriteLine(ans);
        }
    }
}
