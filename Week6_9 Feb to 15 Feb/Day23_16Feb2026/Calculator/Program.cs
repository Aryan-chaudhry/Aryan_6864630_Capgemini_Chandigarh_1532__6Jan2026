namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculators c = new Calculators();
            Console.WriteLine(c.Add(3, 4));
            Console.WriteLine(c.Sub(3, 4));
            Console.WriteLine(c.Mul(3, 4));
            Console.WriteLine(c.Div(3, 4));
        }
    }
}
