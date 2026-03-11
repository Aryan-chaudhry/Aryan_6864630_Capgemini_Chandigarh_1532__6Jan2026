namespace mostRepeated
{
    internal class Program
    {
        public void MostFrequent()
        {
            int[] arr = new int[] { 2, 2, 2, 2, 3, 3, 3, 3, 4 };

            List<int> result = new List<int>();
            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach(int no in arr)
            {
                if (freq.ContainsKey(no))
                {
                    freq[no]++;
                }
                else
                {
                    freq[no] = 1;
                }
            }

            int maxCount = freq.Values.Max();

            foreach(var item in freq)
            {
                if(item.Value == maxCount)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine("{ " + string.Join(", ", result) + " }");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.MostFrequent();
        }
    }
}
