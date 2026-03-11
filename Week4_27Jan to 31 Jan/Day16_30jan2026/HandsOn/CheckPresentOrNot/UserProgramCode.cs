using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CheckPresentOrNot
{
    internal class UserProgramCode
    {
        public static bool Check(string input1, string input2, string input3)
        {
            if(input1.Contains(input2) && input1.Contains(input3))
            {
                int input2Index = input1.IndexOf(input2);
                int input3Index = input1.IndexOf(input3);

                if(input2Index < input3Index)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
