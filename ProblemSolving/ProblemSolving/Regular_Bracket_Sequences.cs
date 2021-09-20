using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class Regular_Bracket_Sequences
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {

                var bracketSeq = Convert.ToInt32(Console.ReadLine());

                var singleBracket = "()";

                for (int i = bracketSeq; i > 0; i--)
                {
                    var bracketLine = string.Empty;

                    var encapBracket = bracketSeq - i;

                    for (int j = i; j > 0; j--)
                    {
                        bracketLine += singleBracket;
                    }

                    for (int m  = 0; m < encapBracket; m++)
                    {
                        bracketLine = "(" + bracketLine + ")";
                    }

                    Console.WriteLine(bracketLine);
                }
            }
        }

    }
}
