using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Translation
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToCharArray();
            string reversedWord = Console.ReadLine();

            Array.Reverse(word);
            string trWord = string.Join("",word);


            if (trWord == reversedWord)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
