using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Recursion
{
    internal class SkipString
    {
        static void Main(string[] args)
        {
            string str = "abcappled";
            string skipStr = "apple";
            string output = Skip(str, skipStr);
            Console.WriteLine(output);
        }

        static string Skip(string str, string skipStr)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }

            if (str.StartsWith(skipStr))
            {
                return Skip(str.Substring(skipStr.Length), skipStr);
            }
            else
            {
                return str[0] + Skip(str.Substring(1), skipStr);
            }
        }
    }
}
