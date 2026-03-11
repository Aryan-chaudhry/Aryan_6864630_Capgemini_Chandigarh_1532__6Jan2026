namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            Console.WriteLine(checkAnagram.check(s1, s2));
        }
    }
}
