namespace ReadFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Path = @"C:\Capgemini_CU_sec3_.netWithAzure_Aryan\Day14_28jan2026\File.txt";

            try
            {
               string data = File.ReadAllText(Path);
                Console.WriteLine(data);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
		}
    }
}
