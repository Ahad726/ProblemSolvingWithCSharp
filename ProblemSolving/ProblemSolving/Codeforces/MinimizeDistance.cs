using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProblemSolving.Codeforces
{
    class MinimizeDistance
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var depotsCount = Convert.ToInt32(line[0]);
                var bagCapacity = Convert.ToInt32(line[1]);
                var depotArray = Console.ReadLine().Split(' ').Take(depotsCount).Select(int.Parse).ToArray();

                var positiveDepotList = new List<int>();
                var negativeDepotList = new List<int>();

                foreach (var depot in depotArray)
                {
                    if (depot < 0)
                    {
                        negativeDepotList.Add(depot);
                    }
                    else
                    {
                        positiveDepotList.Add(depot);
                    }
                }
                positiveDepotList.Sort();
                negativeDepotList.Sort();
                var positiveDistance = 0;

                for (int j = positiveDepotList.Count - 1; j > 0;)
                {
                    positiveDistance += positiveDepotList[j];

                    var lstdepInCapacity = j - bagCapacity + 1;

                    if (lstdepInCapacity >= 0)
                    {
                        positiveDistance += positiveDepotList[j] - positiveDepotList[lstdepInCapacity];
                    }
                    j = lstdepInCapacity - 1;
                    if (j > 0)
                    {
                        positiveDistance += positiveDepotList[lstdepInCapacity];

                    }
                }

                var negativeDistance = 0;
                for (int j = negativeDepotList.Count - 1; j > 0;)
                {
                    negativeDistance -= negativeDepotList[j];
                    var lstdepInCapacity = j - bagCapacity + 1;
                    if (lstdepInCapacity >= 0)
                    {
                        negativeDistance += negativeDepotList[j] - negativeDepotList[lstdepInCapacity];
                    }
                    j = lstdepInCapacity - 1;
                    if (j > 0)
                    {
                        negativeDistance -= negativeDepotList[lstdepInCapacity];

                    }
                }
                Console.WriteLine(positiveDistance + negativeDistance);
            }
        }
    }
}
