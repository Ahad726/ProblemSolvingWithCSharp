using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    class YoungPhysicist
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int sumX = 0;
            int sumY = 0;
            int sumZ = 0;

            for (int i = 0; i < n; i++)
            {
                var coordinates = Console.ReadLine().Split(' ');

                sumX += Convert.ToInt32(coordinates[0]);
                sumY += Convert.ToInt32(coordinates[1]);
                sumZ += Convert.ToInt32(coordinates[2]);

            }

            var output = sumX == 0 && sumY == 0 && sumZ == 0 ? "YES" : "NO";

            Console.WriteLine(output);

        }
    }
}
