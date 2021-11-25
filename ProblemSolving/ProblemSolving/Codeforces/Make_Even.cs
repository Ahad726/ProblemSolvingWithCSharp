using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Codeforces
{
    class Make_Even
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                var number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(EvenMaker(number));

            }
        }

        static int EvenMaker(int number)
        {
            var numberLength = number.ToString().Length;

            int divisor = 1;
            for (int i = 1; i < numberLength; i++)
            {
                divisor *= 10;
            }

            int firstDigit = number / divisor;


            if (number % 2 == 0)
            {
                return 0;
            }

            else if(firstDigit % 2 == 0)
            {
                return 1;
            }

            while (number > 0)
            {
                var numDiv = number / divisor;
                number = number % divisor;
                divisor /= 10;;

                if (numDiv % 2 == 0)
                {
                    return 2;
                }
            }

            return -1;

        }
    }
}
