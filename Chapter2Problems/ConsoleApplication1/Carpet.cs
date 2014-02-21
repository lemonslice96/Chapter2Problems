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
            string lengthInput, widthInput, costInput;
            double area, length = 1, width = 1, cost = 1;
            Console.WriteLine("Enter the length and width of the room.");
            lengthInput = Console.ReadLine();
            widthInput = Console.ReadLine();
            length = Convert.ToInt32(lengthInput);
            width = Convert.ToInt32(widthInput);
            cost = Convert.ToInt32(costInput);
            area = length * width;
            double cost = costInput * area;
            Console.WriteLine("Please enter the cost of the flooring.");
          
      

            Console.WriteLine("The length and width of your room are {0} and {1}", lengthInput, widthInput);
            Console.WriteLine("The Area of your room is {0}",area);
               
         
        }
    }
}

