namespace LamdaWithObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "Aryan Chaudhary", Uid = 16750 });
            students.Add(new Student { Name = "Ayush Chaudhary", Uid = 2628 });

            var record = students.Select(x => new { Name = x.Name, id = x.Uid });

            foreach(var item in record)
            {
                Console.WriteLine(item);
            }
        }
    }
}
