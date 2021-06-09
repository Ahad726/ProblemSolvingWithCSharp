using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class Magnets
    {
        static void Main(string[] args)
        {
            int magnetNumber = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            string firstpair = string.Empty;
            for (int i = 0; i < magnetNumber; i++)
            {
                if (i == 0)
                {
                    firstpair = Console.ReadLine();
                    continue;
                }
                var otherPair = Console.ReadLine();
                if (firstpair[1] == otherPair[0])
                {
                    count++;
                }
                firstpair = otherPair;
            }

            Console.WriteLine(count);
        }
    }
}
