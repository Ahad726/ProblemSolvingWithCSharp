using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class PetyaAndStrings
    {
        static void Main(string[] args)
        {
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();

            int result = String.Compare(firstStr, secondStr, true);

            Console.WriteLine(result);

        }
    }
}
