using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Recursion
{
    internal class Subsequence
    {
        static void Main(string[] args)
        {
            string str = "abc";
            DoSubsequence(string.Empty,str);

        }

        static void DoSubsequence(string p, string u ) // p =  processed  && u = unprocessed
        {
            // base case : when unprocessed is empty , print processed
            if (string.IsNullOrEmpty(u))
            {
                Console.WriteLine(p);
                return;
            }

            char ch = u[0];

            // now either take it then ignore it

            DoSubsequence(p + ch, u.Substring(1));

            DoSubsequence(p , u.Substring(1));
        }
    }
}
