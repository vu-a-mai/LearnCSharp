using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watch_Window
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set a breakpoint
            // Run debug mode
            // Highlight the variable
            // Right click on the variable and add to watch
            // Can also type in the variable/check the variable inside the watch window to check for the value
            // Value return red when step over meaning the value has changed/updated
            string name = "John";
            int age;    // 0
            age = 25;

            if (age > 18)
            {
                Console.WriteLine("18+");
            }
            PrintDetails(name, age);

            string message = ReadFromConsole("Enter something: ");
            Console.WriteLine(message);

            Console.ReadLine();
        }

        static string ReadFromConsole(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        static void PrintDetails(string name, int age)
        {
            // Can also highlight $"{name} - {age}" and dragged into the watch window to display the values
            // very handy to see the output, so we don't have to keep hovering over the value
            Console.WriteLine($"{name} - {age}");
        }
    }
}
