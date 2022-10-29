using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Recursion
{
    internal class Permutation
    {
        static void Main(string[] args)
        {
            FindPermutation("", "ab");
        }

        static void FindPermutation(string processed, string unProcessed)
        {
            if (string.IsNullOrEmpty(unProcessed))
            {
                Console.WriteLine(processed);
                return;
            }

            var ch = unProcessed[0];

            for (int i = 0; i <= processed.Length; i++)
            {
                var firstPart = processed.Substring(0, i);           
                var secondPart = processed.Substring(i,processed.Length - firstPart.Length);
                FindPermutation(firstPart + ch + secondPart, unProcessed.Substring(1));

            }
        }
    }
}
