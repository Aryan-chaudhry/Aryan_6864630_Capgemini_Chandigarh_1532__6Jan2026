namespace AppendData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Path = @"C:\Capgemini_CU_sec3_.netWithAzure_Aryan\Day14_28jan2026\File.txt";

            try
            {
                File.AppendAllText(Path, "are you file? ");
                Console.WriteLine("Data append to file successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can't append data to file " + ex.Message);
            }
		}
    }
}
