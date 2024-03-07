using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 25;

            Console.WriteLine("Your name is " + name + " your age is " + age);

            // Using $ to interpolate
            // insert $ before the string and variable inside {}
            Console.WriteLine($"Your name is {name} your age is {age}");

            Console.ReadLine();
        }
    }
}
