using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Recursion
{
    internal class skipChar
    {
        static void Main(string[] args)
        {
            string str = "baccad";
            string output = string.Empty;
            char ch = 'a';
            Skip(str, output, ch);
        }

        static void Skip(string mainStr, string output , char ch)
        {
            if (string.IsNullOrEmpty(mainStr))
            {
                Console.WriteLine(output);
                return;
            }

            char crntChar = mainStr[0];

            if (crntChar == ch)
            {
                Skip(mainStr.Substring(1),output,ch);
            }
            else
            {
                output += crntChar;
                Skip(mainStr.Substring(1),output,ch);
            }
        }
    }
}
