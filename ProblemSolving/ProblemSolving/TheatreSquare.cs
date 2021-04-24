using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class TheatreSquare
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ');

            var n = Convert.ToInt64(inputLine[0]);
            var m = Convert.ToInt64(inputLine[1]);
            var a = Convert.ToInt64(inputLine[2]);


            //The length of the rectangle is n, and if the side length of the square is a divides n,
            //then there must be n / a squares to cover the full length of n. If n isn’t divisible by a,
            //we need to add 1 to n/ a, to round it down.For this we can use the ceil function, as ceil(x)returns
            //the least integer which is above or equal to x.
            //We can do the same with the rectangle width, and take the number of squares across the width to be ceil(b/ a). 
            //So, total number of squares = ceil(m / a) * ceil(n / a).

            // দৈর্ঘ্যে স্কোয়ারের সংখ্যা * প্রস্থে স্কোয়ারের সংখ্যা

            var count =Convert.ToInt64(Math.Ceiling(m /(double)a) * Math.Ceiling(n /(double) a) );

            Console.WriteLine(count);
          


        }
    }
}
