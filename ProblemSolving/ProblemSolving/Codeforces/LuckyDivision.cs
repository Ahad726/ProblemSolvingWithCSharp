using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class LuckyDivision
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            int count = 0;

            foreach (var digit in number)
            {
                if (digit == '4' || digit == '7')
                {
                    count++;
                }
            }

            var intNumber = Convert.ToInt32(number);

            if (count == number.Length)
                Console.WriteLine("YES");

            else if (intNumber % 4 == 0 || intNumber % 7 == 0 || 
                intNumber % 47 == 0 || intNumber % 74 == 0 || intNumber % 447 == 0 || intNumber % 474 == 0 || intNumber % 747 == 0 || intNumber % 774 == 0)
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
