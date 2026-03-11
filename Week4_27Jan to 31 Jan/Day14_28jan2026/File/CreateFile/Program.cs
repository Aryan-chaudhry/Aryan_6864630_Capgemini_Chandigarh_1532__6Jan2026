using System.IO;

namespace CreateFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Path = @"C:\Capgemini_CU_sec3_.netWithAzure_Aryan\Day14_28jan2026\File.txt";
			try
            {
                File.WriteAllText(Path, "Hi how are you");
                Console.WriteLine("File created Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in creating a file" + ex.Message);
            }

        }
    }
}
