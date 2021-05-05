using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class ChatRoom
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int wordLength = word.Length;

            int hIndex = word.IndexOf('h');

            int eIndex = word.IndexOf('e', hIndex);

            int lindex = word.IndexOf('l', eIndex);

            int scndLindex = word.IndexOf('l', lindex);

            int oIndex = word.IndexOf('o', scndLindex);

            if (hIndex > 0 && eIndex > 0 && lindex > 0 && scndLindex > 0 && oIndex >0 )
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

           
        }
    }
}
