namespace Factory_Robot_Hazard_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ArmPrecison = Convert.ToDouble(Console.ReadLine());
            int workDensity = Convert.ToInt32(Console.ReadLine());
            string MachineryState = Console.ReadLine();

            UserDefinedClass obj = new UserDefinedClass();
            Console.WriteLine(obj.CalculateHazardRisk(ArmPrecison, workDensity, MachineryState));

        }
    }
}
