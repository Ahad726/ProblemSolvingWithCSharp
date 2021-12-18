using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class WordCapitalization
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToCharArray();

            if (!Char.IsUpper(word[0]))
            {
                var firstLetter = word[0] - 32;

                word[0] = (char)firstLetter;
            }

            Console.WriteLine(word);
        }
    }
}
