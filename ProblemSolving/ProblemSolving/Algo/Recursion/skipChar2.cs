using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Recursion
{
    internal class skipChar2
    {
        static void Main(string[] args)
        {
            string str = "abaaccdh";
            char ch = 'a';
            string output = Skip(str, ch);
            Console.WriteLine(output);

        }

        static string Skip(string str, char ch)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }

            char crntChar = str[0];

            if (crntChar == ch)
            {
                return "" + Skip(str.Substring(1), ch);
            }
            else
            {
                return crntChar + Skip(str.Substring(1), ch);
            }
        }

    }
}
