namespace Delegate
{
    internal class Program
    {
        public delegate void Math(int x, int y);

        class MultiClass
        {
            public void add(int x, int y)
            {
                Console.WriteLine("add : " + (x + y));
            }

            public void sub(int x, int y)
            {
                Console.WriteLine("sub : " + (x - y));
            }

            public void mul(int x, int y)
            {
                Console.WriteLine("mul : " + (x * y));
            }

            public void div(int x, int y)
            {
                Console.WriteLine("div : " + (x / y))
;            }
        }

        static void Main(string[] args)
        {
            MultiClass obj = new MultiClass();
            Math m = new Math(obj.add);
             
            m += obj.sub;
            m += obj.mul;
            m -= obj.div;
            m(100, 200);
   //         Console.WriteLine();
   //         m(400, 500);
			//Console.WriteLine();
   //         m -= obj.div;
   //         m(300, 400);
   //         Console.ReadLine();
		}
    }
}
