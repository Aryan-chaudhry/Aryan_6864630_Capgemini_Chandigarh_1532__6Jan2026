namespace NeitherAnagramNorIdentical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "listen", "silent", "hello", "world", "abc", "cba" };

            string[] output = UserProgramCode.Solve(input);

            foreach(string s in output)
            {
                Console.Write(s + " ");
            }
        }
    }
}
