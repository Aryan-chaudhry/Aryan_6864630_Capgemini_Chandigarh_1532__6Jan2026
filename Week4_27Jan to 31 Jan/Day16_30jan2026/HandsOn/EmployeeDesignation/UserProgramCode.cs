using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EmployeeDesignation
{
    internal class UserProgramCode
    {
        public static string[] getEmployee(string[] input1, string input2)
        {
            Dictionary<string, List<string>> dt = new Dictionary<string, List<string>>();

            int i = 0; // name
            int j = 1; // designation

            while(i < input1.Length)
            {
                if (!dt.ContainsKey(input1[j]))
                {
                    dt[input1[j]] = new List<String>();
                    dt[input1[j]].Add(input1[i]);
                }
                else
                {
                    dt[input1[j]].Add(input1[i]);
                }

                i += 2;
                j += 2;
            }

            // return all employee of input2 department
            

            if (dt.ContainsKey(input2))
            {
                return dt[input2].ToArray();
            }

            return ["No Employee Found"];
        }
    }
}
