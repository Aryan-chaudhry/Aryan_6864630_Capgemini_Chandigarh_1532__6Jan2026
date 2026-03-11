using System;
using System.Collections.Generic;
using System.Text;

namespace ExtractExtension
{
    internal class UserProgramCode
    {
        public static string Extract(string file)
        {
            file = file.Trim();

            int index = file.IndexOf(".");

            return file.Substring(index+1);
        }
    }
}
