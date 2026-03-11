namespace GreaterNumberInArray
{
    internal class Program
    {
        public void FindGreater()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 2, 3, 4, 5, 6 };
            int[] output = new int[5];

            for(int i=0; i<arr1.Length; i++)
            {
                if (arr1[i] < 0 || arr2[i] < 0)
                {
                    output[i] = -1;
                }
                else if (arr1[i] >= arr2[i])
                {
                    output[i] = arr1[i];
                }
                else
                {
                    output[i] = arr2[i];
                }
            }


            foreach(int no in output)
            {
                Console.Write(no + " ");
            }

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.FindGreater();
        }
    }
}
