using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_IndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                90, 199, 22, 50, 30
            };

            Console.Write("Enter number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            
            //int position = Array.IndexOf(numbers, search);        // search everything
            //int position = Array.IndexOf(numbers, search, 2);     // start the search from index 2 and onward
            int position = Array.IndexOf(numbers, search, 1, 2);    // give a specific range from 1, and 2 forward, the least amount you can search is the best

            if (position > -1)
            {
                // Adding + 1 to make it more readable
                Console.WriteLine($"Number {search} has been found at {position + 1}");
            }
            else
            {
                Console.WriteLine($"Number {search} has not been found");
            }
            

            /*
            int position = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == search) 
                {
                    position = i;
                }

            }

            if (position > -1) // 0 ->
            {
                // Adding + 1 to make it more readable
                Console.WriteLine($"Number {search} has been found at {position + 1}");
            }
            else
            {
                Console.WriteLine($"Number {search} has not been found");
            }
            */

            Console.ReadLine();
        }
    }
}
