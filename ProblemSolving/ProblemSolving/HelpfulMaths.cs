using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class HelpfulMaths
    {
        static void Main(string[] args)
        {
            var summands = Console.ReadLine().Split('+');

            var lst = new List<int>();
            foreach (var item in summands)
            {
                lst.Add(Convert.ToInt32(item));
            }

            lst.Sort();
           string output = string.Join('+', lst);

            Console.WriteLine(output);
        }
    }
}
