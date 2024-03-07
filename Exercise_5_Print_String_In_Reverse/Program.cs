using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_Print_String_In_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ask user to input message
             * Print in order
             * Print in reverse
             */
            Console.Write("Enter your message: ");
            string message = Console.ReadLine();

            //Console.WriteLine(message[0]);
            //Console.WriteLine(message.Length);

            Console.WriteLine("Printing in order");
            // Print in order
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Printing in reverse");
            // Print in reverse
            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }

            Console.ReadLine();
        }
    }
}
