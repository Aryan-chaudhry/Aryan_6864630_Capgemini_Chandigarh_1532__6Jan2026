namespace FormString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string[] str = new string[size];

            // take input
            for(int i=0; i<size; i++)
            {
                str[i] = Console.ReadLine();
            }

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(UserProgramCode.FormString(str, n));
        }
    }
}
