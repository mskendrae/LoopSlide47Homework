using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopSlide47Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a console application that asks the user for an integer. If that integer 
             * is evenly divisible by 3, then write “You Won!” If it isn’t, write “You Lost.” 
             * Keep asking them for a number (looping) until they win.
             */
                 int counter = 0;
                 Console.WriteLine("Please enter a number:");
            do
            {
              
                int LuckyNum = int.Parse(Console.ReadLine());
                    counter = 0;
                if (LuckyNum % 3 == 0)
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                    counter = 1001;
                } else
                    Console.WriteLine("You Lost.  Please try again.");
                    Console.WriteLine("Please enter a number:");

            } while (counter < 1001);


        }//end main
    }//end class
}//end namespce
