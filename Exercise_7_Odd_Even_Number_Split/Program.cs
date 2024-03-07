using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_Odd_Even_Number_Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create two lists with integer data type, one for even numbers, one for odd
             * Loop from 0 - 20
                * If number is even, add to even list
                * If number is odd, add to odd list
             * Print even list
             * Print odd list
             */

            // Initalize odd and even lists
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    // add even number at index to the list
                    even.Add(i);
                }
                else
                {
                    // add odd number at index to the list
                    odd.Add(i);
                }
            }

            Console.WriteLine("Printing even numbers: ");

            foreach (var item in even)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            Console.WriteLine("Printing odd numbers: ");
            foreach (var item in odd)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
