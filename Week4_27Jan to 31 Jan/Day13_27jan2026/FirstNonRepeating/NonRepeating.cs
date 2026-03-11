using System;
using System.Collections.Generic;
using System.Text;

namespace FirstNonRepeating
{
    internal class NonRepeating
    {
        public static char findNonRepeating(string str)
        {
            for(int i=0; i<str.Length; i++)
            {
                char target = str[i];
                bool isFound = false;

                for(int j=i+1; j<str.Length; j++)
                {
                    if (str[j] == target)
                    {
                        isFound = true;
                        break;
                    }
                }

                if(isFound == false)
                {
                    return target;
                }
            }
            return 'o';
        }
    }
}
