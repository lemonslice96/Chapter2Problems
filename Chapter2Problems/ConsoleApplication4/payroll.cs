using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class payroll
    {
        static void Main(string[] args)
        {
            string name, socialnumber, hoursworked, hourspayed;
            
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Social Security Number: ", name);
            socialnumber = Console.ReadLine();
            Console.Write("Hourly Pay Rate: ");
            hourspayed = Console.ReadLine();
            Console.Write("Hours Worked: ");
            hoursworked = Console.ReadLine();

            Console.Write("Payroll summary for: {0}.", name);
            Console.Write("SSN: {0}.", socialnumber);
            Console.Write("You earned $"{0} * hourspayed"

      


        }
    }
}
