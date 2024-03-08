using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REturn_Type_Functions
{
    internal class Program
    {
        /*
         * A function should only do 1 task
         * If a function do multiple things, then split them
         */
        static void Main(string[] args)
        {
            //Console.Title = $"{ReturnName()} - {ReturnAge()}";
            Console.Title = ReturnNameAgePair();

            PrintIntroduction();

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadNumberFromConsole();
            }

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }

            int[] newNumbers = CreateRandomArray();

            Console.WriteLine();

            foreach (var item in newNumbers)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }

        static void something()
        {
            // conversion
            // calculation
        }

        static void conversion()
        {

        }

        static void calculation()
        {

        }

        static int[] CreateRandomArray()
        {
            //int[] numbers = new int[3]
            //{
            //    0, 1, 2
            //};

            //return numbers;

            // Or make it look neater
            return new int[3] { 0, 1, 2, };
        }

        static int ReadNumberFromConsole()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string ReturnName()
        {
            return "John";
        }

        static int ReturnAge()
        {
            return 30;
        }

        static string ReturnNameAgePair()
        {
            return $"{ReturnName()} - {ReturnAge()}";
        }

        static void PrintIntroduction()
        {
            /*
            string name = ReturnName();
            int age = ReturnAge();
            Console.WriteLine(name);

            // or call directly
            Console.WriteLine(ReturnName());

            string output = ($"Hello my name is {name} and my age is {age}");
            Console.WriteLine(output);
            */

            // directly
            Console.WriteLine($"Hello my name is {ReturnName()} and my age is {ReturnAge()}");
        }
    }
}
