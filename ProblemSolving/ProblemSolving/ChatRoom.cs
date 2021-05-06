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
            int hIndex = 0;
            int eIndex = 0;
            int lindex = 0;
            int scndLindex = 0;
            int oIndex = 0;

            int wordLength = word.Length;

            hIndex = word.IndexOf('h');

            if(hIndex > -1)
                eIndex = word.IndexOf('e', hIndex+1);

            if(eIndex > 0)
                lindex = word.IndexOf('l', eIndex+1);

            if(lindex > 0)
                scndLindex = word.IndexOf('l',lindex+1);

            if(scndLindex > 0)
                oIndex = word.IndexOf('o', scndLindex+1);

            if (hIndex >= 0 && eIndex > 0 && lindex > 0 && scndLindex > 0 && oIndex >0 )
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
