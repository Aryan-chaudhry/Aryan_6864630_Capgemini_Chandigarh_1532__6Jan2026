using System.Text;

namespace ObjectBaseClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            object  name1 = new object();
            object name2 = new object();

            //Console.WriteLine("Object 1 : " + name1);
            //Console.WriteLine("Object 2 : " + name2);
            //Console.WriteLine(name1.Equals(name2));
            //Console.WriteLine(name1 == name2);

            //StringBuilder st = new StringBuilder("Aryan");

            //st[0] = 'r';

            //Console.WriteLine(st);

            string name = "Aryan";
            string ans = name.Replace("A", "a");
            Console.WriteLine(ans);

        }
    }
}
