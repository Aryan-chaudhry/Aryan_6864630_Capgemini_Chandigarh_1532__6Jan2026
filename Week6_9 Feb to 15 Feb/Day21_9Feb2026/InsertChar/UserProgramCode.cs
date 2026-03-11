using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace InsertChar
{
    internal class UserProgramCode
    {
        public static string solve(string s, char ch, int position)
        {
            s = s.Insert(position - 1, ch.ToString());
            return s;
        }
    }
}
