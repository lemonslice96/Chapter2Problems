using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class time
    {
        static void Main(string[] args)
        {
            int hoursandminutes, remainderminutes, minutes = 273;

            hoursandminutes = minutes / 60;
            remainderminutes = minutes % 60; 

            Console.WriteLine("You worked for {0} hours and {1} minutes", hoursandminutes, remainderminutes);
        }
    }
}
