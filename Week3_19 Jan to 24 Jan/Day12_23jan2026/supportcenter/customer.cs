using System;
using System.Collections.Generic;
using System.Text;

namespace supportcenter
{
    internal class customer
    {
        public string Name;
        public string PhoneNumber;

        public static Stack<string> History = new Stack<string>();
    }
}
