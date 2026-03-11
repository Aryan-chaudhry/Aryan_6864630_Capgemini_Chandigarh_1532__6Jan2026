using System.Globalization;

namespace OnlyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size : ");
            int size = Convert.ToInt32(Console.ReadLine());

            string[] str = new string[size];

            for(int i=0; i<size; i++)
            {
                str[i] = Console.ReadLine();
            }

            Console.WriteLine(UserProgramCode.Check(str));
        }
    }
}
