namespace RemoveDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2, 2, 2, 3, 4, 5 };
            int[] ans = UserProgramCode.RemoveDuplicate(nums);

            foreach(var item in ans)
            {
                Console.Write(item + " ");
            }
        }
    }
}
