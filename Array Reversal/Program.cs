using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Reversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] 
            { 
                1, 2, 3, 4 ,5 
            };

            Console.WriteLine("Printing with sorted Array with reverse for loop");
            int[] sortedNumbers = new int[numbers.Length];

            int x = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                sortedNumbers[x] = numbers[i];
                x++;
            }

            foreach (var num in sortedNumbers)
            {

                Console.Write($"{num} ");
            }

            Console.WriteLine();

            Console.WriteLine("Printing with Array.Reverse() function");

            // Array Reverse function
            Array.Reverse(numbers);

            foreach (var number in numbers) 
            {
                Console.Write($"{number} ");
            }

            Console.ReadLine();
        }
    }
}
