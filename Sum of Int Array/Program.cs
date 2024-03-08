using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Int_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create and initalise int array of numbers
             * Create function SumOfNumbers with int return type
             * int array param
             * function should return total of all numbers
             * Call in main and ouput the total
             * 
             * Extra: Check array length
                * return -1 if the array is empty
                * check return in main and ouput the message
                * do we need to return -1, how else can we make this?
             */


            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5
            };

            // Method 1: only work if all values is positive
            int result = SumOfNumbers(numbers);

            if (result > -1)
            {
                Console.WriteLine($"The total is: {result}");
            }
            else
            {
                Console.WriteLine($"Cannot add up an emtpy array!");
            }

            // Method 2 without returning -1
            if (SumOfNumbers(numbers, out int total))
            {
                Console.WriteLine($"The total is: {result}");
            }
            else
            {
                Console.WriteLine($"Cannot add up an emtpy array!");
            }

            Console.ReadLine();
        }

        static int SumOfNumbers(int[] numbers)
        {
            if (numbers.Length > 0 )
            {
                int total = 0;

                foreach (var item in numbers)
                {
                    total += item;
                }

                return total;
            }

            return -1;
        }

        static bool SumOfNumbers(int[] numbers, out int total)
        {
            total = 0;

            if (numbers.Length > 0)
            {

                foreach (var item in numbers)
                {
                    total += item;
                }

                return true;
            }

            return false;
        }
    }
}
