using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class WayTooLongWords
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string inputString = Console.ReadLine();
                int length = inputString.Length;

                if (length > 10)
                {
                    inputString = inputString.Remove(1, length - 2);
                    inputString = inputString.Insert(1, (length - 2).ToString());
                }

                Console.WriteLine(inputString);
            }
        }
    }
}
