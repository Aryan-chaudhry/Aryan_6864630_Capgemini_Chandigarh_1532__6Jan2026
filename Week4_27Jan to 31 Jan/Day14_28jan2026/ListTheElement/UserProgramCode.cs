using System;
using System.Collections.Generic;
using System.Text;

namespace ListTheElement
{
    internal class UserProgramCode
    {
        public static List<int> GetElements(List<int>input1, int input2)
        {
            List<int> Ans = new List<int>();

            if(input1.Count == 0)
            {
                Ans.Add(-1);
                return Ans;
            }

            foreach(int item in input1)
            {
                if(item < input2)
                {
                    Ans.Add(item);
                }
            }

            Ans.Sort();
            Ans.Reverse();

            return Ans;
        }
    }
}
