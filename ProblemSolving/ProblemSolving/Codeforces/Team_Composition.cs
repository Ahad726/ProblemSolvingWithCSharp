using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Codeforces
{
    class Team_Composition
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var numOfProg = Convert.ToInt32(line[0]);
                var numOfMathm = Convert.ToInt32(line[1]);
                Console.WriteLine(TeamComposer(numOfProg,numOfMathm));

            }
        }

        static int TeamComposer(int numOfProg, int numOfMathm)
        {
            if (numOfMathm == 0 || numOfProg == 0)
            {
                return 0;
            }

            int totalTeamCount = (numOfProg + numOfMathm) / 4;

            if (numOfProg > numOfMathm)
            {
                numOfProg = numOfMathm;
            }
            else
            {
                numOfMathm = numOfProg;
            }

            if (totalTeamCount > numOfProg)
            {
                return numOfProg;
            }
            else
            {
                return totalTeamCount;
            }
        }
    }
}
