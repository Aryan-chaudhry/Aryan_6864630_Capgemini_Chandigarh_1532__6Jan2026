namespace ConsoleApp1.handsOn2
{
    internal class Method
    {
        void test1()
        {
            Console.WriteLine("This is the first Method");
        }

        void test2(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        string test3()
        {
            string s = "hi how are you!";
            return s;
        }

        string test4(string name)
        {
            return "Hi my name is " + name;
        }

        void test5(int x, int y, ref int a, ref int b)
        {
            a = x + y;
            b = x - y;
        }

        void test6(int x, int y, out int m, out int n)
        {
            m = x * y;
            n = x - y;
        }

        static void Main(string[] args)
        {
            Method m = new Method();
            m.test1();
            m.test2("Aryan");

            string ans1 = m.test3();
            Console.WriteLine(ans1);

            string ans2 = m.test4("Aryan");
            Console.WriteLine(ans2);

            int y = 0, z = 0;
            m.test5(3, 5, ref y, ref z);
            Console.WriteLine("y : " + y + " z : " + z);

            int q, r;
            m.test6(2, 4, out q, out r);
            Console.WriteLine("q : " + q + " r : " + r);
        }
    }
}
