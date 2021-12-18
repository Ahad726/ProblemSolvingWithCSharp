using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    class StringTask
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();

            var vowels =new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };

            string result = string.Empty;


            for (int i = 0; i < input.Length; i++)
            {
                if (!vowels.Contains(input[i]))
                {
                    result += "." + input[i];
                }
                              
            }

            Console.WriteLine(result);


        }
    }
}
