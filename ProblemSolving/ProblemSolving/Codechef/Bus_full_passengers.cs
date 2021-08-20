using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Codechef
{
    public class Bus_full_passengers
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var line = Console.ReadLine().Split(' ');
                var people = Convert.ToInt64(line[0]);
                var seats = Convert.ToInt64(line[1]);
                var events = Convert.ToInt64(line[2]);

                var consistency = true;
                var enteredPplList = new List<string>();

                var allInputs = new List<string>();

                for (int i = 0; i < events; i++)
                {
                    allInputs.Add(Console.ReadLine());
                }

                for (int i = 0; i < events; i++)
                {
                    var evnt = allInputs[i];

                    if (evnt.StartsWith("+"))
                    {
                        enteredPplList.Add(evnt);
                        if (enteredPplList.Count > seats)
                        {
                            consistency = false;
                            break;
                        }
                    }
                    else
                    {
                        evnt = evnt.Replace('-', '+');
                        if (!enteredPplList.Contains(evnt))
                        {
                            consistency = false;
                            break;
                        }
                        else
                        {
                            enteredPplList.Remove(evnt);
                        }

                    }
                }

                var result = consistency == true ? "Consistent" : "Inconsistent";

                Console.WriteLine(result);
               
            }
        }
    }
}
