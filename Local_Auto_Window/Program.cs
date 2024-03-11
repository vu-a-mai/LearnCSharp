using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Auto_Window
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age;    // 0
            age = 25;

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
            Console.WriteLine($"{name} - {age}");
        }
    
    }
}
