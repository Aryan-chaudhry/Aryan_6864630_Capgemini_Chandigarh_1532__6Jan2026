using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ParanthesisChecker
{
    internal class checkParenthesis
    {
        public static string validate(string str)
        {
            Stack<char> st = new Stack<char>();

            foreach(char ch in str)
            {
                if(ch == '(' || ch == '[' || ch == '{')
                {
                    st.Push(ch);
                }
                else if(ch == ')' && st.Peek() == '(')
                {
                    st.Pop();
                }
                else if(ch == ']' && st.Peek() == '['){
                    st.Pop();
                }
                else if(ch == '}' && st.Peek() == '{')
                {
                    st.Pop();
                }
                else
                {
                    return "Invalid";
                }
            }
            return st.Count == 0 ? "Valid" : "Invalid";
        }
    }
}
