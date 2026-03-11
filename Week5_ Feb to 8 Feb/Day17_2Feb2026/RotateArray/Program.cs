namespace RotateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, -100, 3, 99 };
            int k = 2;

            int[] ans = UserProgramCode.Rotate(nums, k);

            foreach(var item in ans)
            {
                Console.Write(item + " ");
            }
        }
    }
}
