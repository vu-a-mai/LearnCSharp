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
