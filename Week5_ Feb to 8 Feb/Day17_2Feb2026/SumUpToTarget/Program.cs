namespace SumUpToTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums =  { 2, 7, 11, 9 };
            int target = 9;
            int[] ans = UserProgramCode.getAns(nums, target);

            foreach(int index in ans)
            {
                Console.Write(index + " ");
            }
        }
    }
}
