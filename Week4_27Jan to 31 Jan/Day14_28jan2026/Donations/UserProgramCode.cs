using System;
using System.Collections.Generic;
using System.Text;

namespace Donations
{
    internal class UserProgramCode
    {
        public static int GetDomain(string[] input1, int input2)
        {
            // if duplicate return -1
            for(int i=0; i<input1.Length; i++)
            {
                for(int j=i+1; j<input1.Length; j++)
                {
                    if (input1[i].Equals(input1[j]))
                    {
                        return -1;
                    }
                }
            }

            // return -2 if contain any special character
            foreach(string str in input1)
            {
                foreach(char ch in str)
                {
                    if(char.IsLetterOrDigit(ch) == false)
                    {
                        return -2;
                    } 
                }
            }

            string location = input2.ToString();
            int sum = 0;

            foreach(string str in input1)
            {
                if (str.Substring(3, 3).Equals(location))
                {
                    sum += Convert.ToInt32(str.Substring(6, 3));
                }
            }
            return sum;
        }
    }
}
