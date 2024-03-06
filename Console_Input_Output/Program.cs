using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Input_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello my name is John");

            Console.Write("Enter your name: ");

            string name = Console.ReadLine();

            //Console.WriteLine($"Hello {name}");

            Console.Write("Enter your age: ");

            // Console.ReadLine can only take in a string input
            //string ageInput = Console.ReadLine();
            
            // Convert string to Int32
            //int age = Convert.ToInt32(ageInput);

            // Or do it in one line
            int newAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Printing from newAge: {newAge}");

            //Console.WriteLine($"Your name is: {name}");
            //Console.WriteLine($"Your age is: {age}");

            Console.WriteLine();

            //Console.WriteLine("Your name is " + name + " and your age is " + age);
            Console.WriteLine("Your name is " + name + " and your age is " + newAge);

            Console.ReadLine();
        }
    }
}
