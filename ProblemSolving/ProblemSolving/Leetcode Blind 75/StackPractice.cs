using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Leetcode_Blind_75
{
    internal class StackPractice
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("[{()}]"));
        }

        public static bool IsValid(string s)
        {
            var stack = new Stack<char>();

            var pairs = new Dictionary<char, char>()
            {
                [']'] = '[',
                ['}'] = '{',
                [')'] = '('
            };

            for (int i = 0; i < s.Length; i++)
            {
                if (!pairs.ContainsKey(s[i]))
                {
                    stack.Push(s[i]);
                }
                else if(stack.Count == 0 || stack.Pop() != pairs[s[i]])
                {
                    return false;
                }
            }

            return stack.Count == 0;

        }
    }
}
