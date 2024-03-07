using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 25;

            Console.WriteLine("Your name is " + name + " and your age is " + age);

            // Using $ to interpolate
            // insert $ before the string and variable inside {}
            Console.WriteLine($"Your name is {name} and your age is {age}");

            Console.WriteLine("Your name is {0} and your age is {1}", name, age);

            // Using Concat function
            string test = string.Concat("Your name is ", name, " and your age is ", age);
            Console.WriteLine(test);

            string[] names = new string[] { "John ", "Adam ", "Ben " };
            Console.WriteLine(string.Concat(names));

            Console.ReadLine();
        }
    }
}
