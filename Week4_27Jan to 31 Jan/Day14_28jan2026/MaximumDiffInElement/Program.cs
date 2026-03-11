namespace MaximumDiffInElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] input1 = new int[n];

            for(int i=0; i<n; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(UserProgramCode.diffInArray(input1));
        }
    }
}
