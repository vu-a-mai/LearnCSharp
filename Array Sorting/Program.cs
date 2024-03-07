using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                //1, 2, 3, 4, 5, 6, 7, 8, 9
                9, 2, 0 , 8, 1, 5, 6, 4, 3, 2
            };

            string test = "";
            test.Replace(" ", "");

            // Array Sort functions
            Array.Sort(numbers);

            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }            
            
            Console.ReadLine();
        }
    }
}
