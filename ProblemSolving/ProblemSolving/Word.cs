using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Word
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int lowerCount = 0;
            int upperCount = 0;

            foreach (var letter in word)
            {
                if (Char.IsLower(letter))
                {
                    lowerCount++;
                }
            }

            upperCount = word.Length - lowerCount;

            if (lowerCount >= upperCount)
            {
                Console.WriteLine(word.ToLower());
            }
            else
            {
                Console.WriteLine(word.ToUpper());
            }
        }
    }
}
