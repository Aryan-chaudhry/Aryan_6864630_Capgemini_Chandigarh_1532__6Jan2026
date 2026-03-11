using System;
using System.Collections.Generic;
using System.Text;

namespace CountElements
{
    internal class UserProgramCode
    {
        public static int GetCount(string[]words , char ch)
        {
            int count = 0;

            foreach(string str in words)
            {
                if (Char.ToLower(str[0]) == Char.ToLower(ch))
                {
                    count++;
                }
            }

            return count == 0 ? -1 : count;
        }
    }
}
