using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumPossibleDeletion
{
    internal class UserProgramCode
    {
        public static int Solve(string str)
        {
            int count = 0;

            Stack<char> st = new Stack<char>();

            foreach(char ch in str)
            {
                if(st.Count == 0)
                {
                    st.Push(ch);
                }
                else if(st.Count >= 1 && st.Peek() == ch)
                {
                    st.Pop();
                    count++;
                }
                else
                {
                    st.Push(ch);
                }
            }
            return count;
        }
    }
}
