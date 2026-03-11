namespace reachTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int target = 0;
            target = Convert.ToInt32(Console.ReadLine());
            int number = 10;
            int ans = ReachTarget.FindMinOperations(number, target);
            Console.WriteLine(ans);

		}
    }
}
