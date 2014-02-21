using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class HoursandMinutes
    {
        static void Main(string[] args)
        {
            int hoursandminutes, minutes = 273;

            hoursandminutes = minutes / 60 % 60;

            Console.WriteLine("{0}", hoursandminutes);
        }
    }
}
