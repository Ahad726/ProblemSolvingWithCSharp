using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class AntonAndDanik
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string match = Console.ReadLine();
            int aktonCount = 0;
            int danikCount = 0;

            foreach (var letter in match)
            {
                if (letter == 'A')
                {
                    aktonCount++;
                }
            }

            danikCount = n - aktonCount;

            if (aktonCount > danikCount)
            {
                Console.WriteLine("Anton");
            }
            else if(aktonCount < danikCount)
            {
                Console.WriteLine("Danik");
            }
            else
            {
                Console.WriteLine("Friendship");
            }
        }
    }
}
