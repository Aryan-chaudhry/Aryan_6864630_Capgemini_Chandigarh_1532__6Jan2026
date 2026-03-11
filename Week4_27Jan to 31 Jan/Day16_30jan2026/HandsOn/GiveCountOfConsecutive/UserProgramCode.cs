using System;
using System.Collections.Generic;
using System.Text;

namespace GiveCountOfConsecutive
{
    internal class UserProgramCode
    {
        public static int GiveCount(string str)
        {
            int count = 0;
            int currCount = 1;

            for(int i=0; i<str.Length-1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    currCount++;
                }               
                
                if(currCount == 3)
                {
                    count++;
                    currCount = 1;
                }
            }

            if(currCount == 3)
            {
                count++;
            }

            return count;
        }
    }
}
