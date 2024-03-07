using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Clearing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            // Array.Clear will assigned all the position to the value of 0
            //Array.Clear(numbers, 0, numbers.Length);
            Array.Clear(numbers, 5, 5); // start at 5th position and go 5 forward

            /*
            // Using for loop to assigned to default
            for (int i = 0; i < numbers.Length; i++)
            {
                // numbers[i] = 0;
                // use default value, so you don't have to remember the data type
                // easier and safer option
                numbers[i] = default;
            }

            // Using for loop to reassigned starting from index 5 to 10 
            for (int i = 5; i < 10; i++) // 5 6 7 8 9
            {
                numbers[i] = default;
            }
            */

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
