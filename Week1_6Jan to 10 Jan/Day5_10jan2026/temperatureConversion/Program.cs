using System.Diagnostics.Metrics;

namespace temperatureConversion
{
    internal class Program
    {
        public double ConvertTemperature()
        {
            Console.Write("Enter temp in fahrenheit : ");
            double tempInFahrenheit = Convert.ToDouble(Console.ReadLine());
            double output = 0;

            if(tempInFahrenheit < 0)
            {
                output = -1;
            }
            else
            {
                double celcius = (tempInFahrenheit - 32) * 5 / 9;
                output = celcius;
            }
            return output;
        }

		static void Main(string[] args)
        {
            Program obj = new Program();
            double output = obj.ConvertTemperature();
            Console.Write(output);
        }
    }
}
