using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Football
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int temp = input[0];
            int count = 1;

            for (int i = 1; i < input.Length ; i++)
            {
                if (count > 6)
                {
                    break;
                }
                if (input[i] == temp)
                {
                    count++;
                }
                else
                {
                    temp = input[i];
                    count = 1;
                }
            }

            if (count > 6)
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
