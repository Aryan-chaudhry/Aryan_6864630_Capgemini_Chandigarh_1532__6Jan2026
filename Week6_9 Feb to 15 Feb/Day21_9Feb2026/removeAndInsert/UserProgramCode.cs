using System;
using System.Collections.Generic;
using System.Text;

namespace removeAndInsert
{
    internal class UserProgramCode
    {
        public static string Solve(string str, string remove, string insert)
        {
            int index = str.IndexOf(remove);
            str = str.Remove(index, remove.Length);
            str = str.Insert(index, insert);
            return str;
        }
    }
}
