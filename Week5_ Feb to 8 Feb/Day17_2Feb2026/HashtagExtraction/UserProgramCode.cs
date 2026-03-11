using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HashtagExtraction
{
    internal class UserProgramCode
    {
        public static void extractHashtag(string message)
        {
            var allhashtags = Regex.Matches(message, @"#[a-zA-Z0-9]+");

            foreach(var hastag in allhashtags)
            {
                Console.WriteLine(hastag);
            }
        }
    }
}
