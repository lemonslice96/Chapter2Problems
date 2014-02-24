using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Carpet
    {
        static void Main(string[] args)
        {
            double area, totalCost, length = 15, width = 25, cost = 3.28;

            area = length * width;
            totalCost = cost * area;

            Console.WriteLine("The area of your room is {0}.",area);
            Console.WriteLine("The total carpet cost of your room is ${0}.", totalCost);
               
         
        }
    }
}

