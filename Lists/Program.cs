using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3]
            {
                1, 2, 3
            };

            // A List is dynamic, we can add as many as we want
            List<int> listNumbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }

            // remove value at index 0, which is 1
            listNumbers.RemoveAt(0);

            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
