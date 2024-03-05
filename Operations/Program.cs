using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = 23;
            Console.WriteLine($"Current Age: {age}");
            // Addition

            // increase by 1
            // There is a few ways
            // Method 1 : can only increase by 1
            Console.WriteLine("Adding 1");
            age++;
            Console.WriteLine(age);
            // Method 2 and 3 can be flexible. For example age + 10;
            // Method 2
            Console.WriteLine("Adding 1");
            age = age + 1;
            Console.WriteLine(age);
            // Method 3
            age += 1;
            Console.WriteLine("Adding 1");
            Console.WriteLine(age);

            // Subtraction

            // decrease by 1
            Console.WriteLine("Subtracting 1");
            age--;
            Console.WriteLine(age);
            Console.WriteLine("Subtracting 2");
            age -= 2;
            Console.WriteLine(age);

            // Multiply
            Console.WriteLine("Multiply by 2");
            age *= 2;
            Console.WriteLine(age);

            // Divide
            Console.WriteLine("Divide by 10");
            age /= 10; // 46 / 10 -> 4.6
            Console.WriteLine(age);

            // For string we can only use + to concatenate string together
            string name = "John";
            name += " is running!";
            Console.WriteLine(name);

            // For char it adding unicode value
            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine($"Current i value = {i}");
            Console.WriteLine("Console.WriteLine(i++) will print the current i value and will not print the increase i.");
            Console.WriteLine(i++);
            Console.WriteLine("Now we print the i after Console.WriteLine(i++).");
            Console.WriteLine(i);
            Console.WriteLine("Console.WriteLine(++i) will increase the current i value and then print.");
            Console.WriteLine(++i);
            Console.WriteLine("Now we print the i after Console.WriteLine(++i).");
            Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
