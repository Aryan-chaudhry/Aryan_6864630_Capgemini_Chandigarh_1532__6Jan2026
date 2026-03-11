using System;
using System.Collections.Generic;
using System.Text;

namespace EligibleForVote
{
    internal class UserProgramCode
    {
        public static string CheckEligibility(int age)
        {
            return age >= 18 ? "Eligible" : "Not Eligible";
        }
    }
}
