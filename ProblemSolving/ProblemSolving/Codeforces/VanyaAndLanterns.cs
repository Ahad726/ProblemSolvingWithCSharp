using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    // (1) First check the max distance between two lanterns. And make it half for each called radius
    // (2) Then , Compare the above radius with (0 to first lantern) and select greater value as radius.
    //(3) After that, Compare the radius with ( road length - last lantern) and again select  greater value as radius.

    class VanyaAndLanterns
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');

            int totalLantern = Convert.ToInt32(line[0]);
            long length = Convert.ToInt64(line[1]);

            var lanternPosition = Console.ReadLine().Split(' ').Take(totalLantern).Select(long.Parse).ToArray();

            Array.Sort(lanternPosition);


            double maxDistance = 0;
            long tempDistance = 0;

            for (int i = 0; i < lanternPosition.Length - 1; i++)
            {
                tempDistance = lanternPosition[i + 1] - lanternPosition[i];
                if (tempDistance > maxDistance)
                {
                    maxDistance = tempDistance;
                }
            }

            double radius = maxDistance / 2;

            if (lanternPosition[0] > radius)
            {
                radius = lanternPosition[0];
            }

            double lastBoundDistance = length - lanternPosition[totalLantern - 1];
            if (lastBoundDistance > radius)
            {
                radius = lastBoundDistance;
            }
            Console.WriteLine("{0:F10}", radius);
        }
    }
}
