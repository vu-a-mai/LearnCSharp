using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedDataTypes
{
    internal class String_Chars
    {
        static void Main(string[] args)
        {
            // Declare a string variable name
            String name = "John";
            // Declare a char variable letter
            char letter = 'a';

            // Print without a new line
            Console.Write("Your name is ");
            Console.Write(name);

            // Print with a new line
            Console.WriteLine();
            Console.WriteLine(letter);   

            Console.ReadLine();
        }
    }
}
