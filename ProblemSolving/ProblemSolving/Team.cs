using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Team
    {
        static void Main(string[] args)
        {

            int totalProblems = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < totalProblems; i++)
            {
                var line = Console.ReadLine().Split(' ');

                int petyaSolution = Convert.ToInt32(line[0]);
                int vasyaSolution = Convert.ToInt32(line[1]);
                int tonyaSolution = Convert.ToInt32(line[2]);

                if (petyaSolution + vasyaSolution + tonyaSolution > 1)
                {
                    count++;
                }
            }

            Console.WriteLine(count);

           
        }
    }
}
