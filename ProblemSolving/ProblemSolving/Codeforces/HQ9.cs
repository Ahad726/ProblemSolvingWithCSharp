using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class HQ9
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            bool isMatch = false;

            foreach (var ch in line)
            {
                if (ch == 'H' || ch == 'Q' || ch =='9' )
                {
                    isMatch = true;
                }

            }

            string result = isMatch == true ? "YES" : "NO";
            Console.WriteLine(result);
        }
    }
}
