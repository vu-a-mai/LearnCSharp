using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4_Fizz_Buzz_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a for loop from 1 to X (15)
             * 3 and 5 = FizzBuzz
             * 3 = Fizz
             * 5 = Buzz
             * else = nummber
             */

            //Console.WriteLine("Enter a number: ");

            bool threeDiv = false;
            bool fiveDiv= false;

            for (int i = 0; i < 100; i++)
            {
                // Much more efficient for memory
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;

                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


            Console.ReadLine();
        }
    }
}
