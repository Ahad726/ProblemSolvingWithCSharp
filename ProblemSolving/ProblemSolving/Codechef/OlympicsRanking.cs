using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Codechef
{
    public class OlympicsRanking
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {   
                var medalsArray = Console.ReadLine().Split(' ').Take(6).Select(int.Parse).ToArray();

                var firstCountryMedal = medalsArray[0] +medalsArray[1] + medalsArray[2];
                var secondCountryMedal = medalsArray[3] +medalsArray[4] + medalsArray[5];

                Console.WriteLine(firstCountryMedal > secondCountryMedal ? 1 : 2);
            }
        }
    }
}
