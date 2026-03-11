namespace removeAndInsert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "HelloWorld";
            string remove = "World";
            string word = "Universe";

            Console.WriteLine(UserProgramCode.Solve(str, remove, word));
        }
    }
}
