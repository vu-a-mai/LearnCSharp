using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Define and initalise two integers (num, length)
             * (7, 5) -> [7, 14, 21, 28, 35]
             * Create int array with size length
             * loop through and insert the (loop counter x num) into the array
             * print the final array
             */

            //int num = 7;
            //int length = 5;

            // Challenge: Ask user to input the num and length
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a length for the array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] result = new int[length];
            int counter = 0;

            //for (int i = 1; i <= result.Length; i++)  // 0 - 4   1 - 5
            //{
            //    result[counter] = num * i;
            //    counter++;
            //}
            
            // or increment the counter inside the for loop after i++
            for (int i = 1; i <= result.Length; i++, counter++)
            {
                result[counter] = num * i;
            }

            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }

            Console.Write("Final list in the array: ");
            foreach (var item in result) 
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
