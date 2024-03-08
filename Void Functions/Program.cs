using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome function
            WelcomeMessage();

            // Create and Print Array function
            CreateAndPrintArray();

            Console.ReadLine();
        }

        static void CreateAndPrintArray()
        {
            int[] numbers = new int[5] { 0, 1, 2, 3, 4 };

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my program!");
        }
    }
}
