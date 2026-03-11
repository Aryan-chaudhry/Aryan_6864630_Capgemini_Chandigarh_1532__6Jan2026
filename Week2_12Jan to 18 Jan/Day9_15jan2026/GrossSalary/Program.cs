namespace GrossSalary
{
    internal class Program
    {
        public double CalculateGrossSalary()
        {
            Console.Write("Enter basic Salary : ");
            double basicSalary = Convert.ToDouble(Console.ReadLine());
            double grossSalary = 0;

            if(basicSalary < 0)
            {
                grossSalary = -1;
                return grossSalary;
            }

            if(basicSalary > 10000)
            {
                grossSalary = -2;
                return grossSalary;
            }

            grossSalary = basicSalary + basicSalary * 0.75 + basicSalary * 0.5;
            return grossSalary;
        }

		static void Main(string[] args)
        {
            Program obj = new Program();
            double output = obj.CalculateGrossSalary();
            Console.Write(output);
        }
    }
}
