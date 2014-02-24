using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Eggs
    {
        static void Main(string[] args)
        {
            int totaleggs, dozeneggs, remaindereggs, chicken1 = 30, chicken2 = 7, chicken3 = 19, chicken4 = 24;
            totaleggs = chicken1 + chicken2 + chicken3 + chicken4;
            dozeneggs = totaleggs / 12;
            remaindereggs = totaleggs % 12;

            Console.WriteLine("All four chickens produced a total of {0} dozen and {1} eggs combined.", dozeneggs, remaindereggs);

        }
    }
}
