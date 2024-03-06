using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            */

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hi");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Printing all even from 0 to 10");
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.Write("What do you want to repeat?: ");
            string message = Console.ReadLine();
            Console.Write("How many time do you want to repeat it?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());
            
            // Taking care of case where user enter less than 0
            if (loopCounter <= 0)
            {
                Console.WriteLine("Sorry, please enter a value above 0");
            }
            else // >= 1
            {

                for (int i = 0; i < loopCounter; i++)
                {
                    Console.Write(i + ":");
                    Console.WriteLine(message);
                }
            }

            Console.ReadLine();
        }
    }
}
