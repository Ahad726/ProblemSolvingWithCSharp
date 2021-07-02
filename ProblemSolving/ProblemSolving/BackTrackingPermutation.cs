using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class BackTrackingPermutation
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Permutation(str, 0, str.Length - 1);

        }

        private static void Permutation(string str, int leftBound, int rightBound)
        {
            if (leftBound == rightBound)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = leftBound; i <= rightBound; i++)
                {
                    // do
                    str = Swap(str, leftBound, i);
                    // Recure
                    Permutation(str, leftBound + 1, rightBound);

                    // Undo 
                    str = Swap(str, leftBound, i);
                }
            }

           


        }

        private static string Swap(string str, int leftBound, int i)
        {
            var strChar = str.ToCharArray();
            char temp;

            temp = strChar[leftBound];
            strChar[leftBound] = strChar[i];

            
            strChar[i] = temp;

            return new string(strChar);
        }
    }
}
