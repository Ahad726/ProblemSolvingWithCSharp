using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class EasyProblem
    {
        static void Main(string[] args)
        {
            int totalPeople = Convert.ToInt32(Console.ReadLine());
            var opinion = Console.ReadLine();

            if (opinion.Contains('1'))
            {
                Console.WriteLine("HARD");
            }
            else
            {
                Console.WriteLine("EASY");
            }
        }
    }
}
