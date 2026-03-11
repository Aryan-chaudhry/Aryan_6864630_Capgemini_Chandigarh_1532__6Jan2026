namespace ListTheElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input1 = new List<int>() { 1, 4, 7, 3, 9, 15, 24 };
            int input2 = 17;

            var output = UserProgramCode.GetElements(input1, input2);

            foreach(var item in output)
            {
                Console.Write(item + " ");                             
            }
        }
    }
}
