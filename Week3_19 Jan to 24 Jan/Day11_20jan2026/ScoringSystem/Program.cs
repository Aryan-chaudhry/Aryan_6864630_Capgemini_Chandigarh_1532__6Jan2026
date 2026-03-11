namespace ScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y, N1, N2, M;
            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToInt32(Console.ReadLine());
            N1 = Convert.ToInt32(Console.ReadLine());
            N2 = Convert.ToInt32(Console.ReadLine());
            M = Convert.ToInt32(Console.ReadLine());

            studentMarks obj = new studentMarks();
            obj.CheckMarks(X,Y,N1,N2,M);
        }
    }
}
