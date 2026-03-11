using System.Xml.Serialization;

namespace SerilizationAndDeserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students s = new Students { id = 16750, name = "Aryan" };

           
			string path = @"C:\Capgemini_CU_sec3_.netWithAzure_Aryan\Day15_29jan2026\student.xml";

            // serilization

            // create a file stream
            FileStream fs = new FileStream(path, FileMode.Create);

            // serialize to xml
            XmlSerializer serializer = new XmlSerializer(typeof(Students));

            // serialize object to xml format
            serializer.Serialize(fs, s);
            fs.Close();

            Console.WriteLine("xml Serializable Completed File Created");

            // deserilization

            FileStream fsRead = new FileStream(path, FileMode.Open);

            Students desirializer = (Students)serializer.Deserialize(fsRead);
            fsRead.Close();

            Console.WriteLine(desirializer.id + "\n" + desirializer.name);

            
        }
    }
}
