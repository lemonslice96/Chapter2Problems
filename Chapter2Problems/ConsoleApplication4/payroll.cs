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
            string name, socialnumber;
            double hourspay, hourswork, totalpay;
            
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Social Security Number: ", name);
            socialnumber = Console.ReadLine();
            Console.Write("Hourly Pay Rate: ");
            hourspay = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours Worked: ");
            hourswork = Convert.ToDouble(Console.ReadLine());
            totalpay = hourspay * hourswork;
            Console.WriteLine(" ");
            Console.WriteLine("Payroll summary for {0}: ", name);
            Console.WriteLine("SSN: {0}", socialnumber);
            Console.WriteLine("You earned ${0} at ${1} per hour.", totalpay, hourspay);
            Console.WriteLine(" ");
            Console.WriteLine("Gross pay: {0, 18}.", totalpay);
            Console.WriteLine("Feederal withholding: {0, 20}.", totalpay % 1.5f);
            Console.WriteLine("State withholding: {0, 10}.", totalpay % 0.5f);
            Console.WriteLine("Net pay: {0, 20}.", totalpay);

        }
    }
}
