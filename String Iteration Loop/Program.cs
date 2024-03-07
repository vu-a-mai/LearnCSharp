using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace String_Iteration_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is awesome";
            //char[]
            /*
            Console.WriteLine(message[0]);  // C
            Console.WriteLine(message[1]);  // #
            Console.WriteLine(message[2]);  // 
            Console.WriteLine(message[3]);  // i

            // Index out of range
            //Console.WriteLine(message[30]);  // i
            */

            // using string Length
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(50); // 1000 ms = 1 sec
            }

            Console.WriteLine();
            Console.WriteLine(message.Contains("C"));

            // initialize contains to false
            bool contains = false;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Equals('C'))
                {
                    contains = true;
                }
            }

            Console.WriteLine(contains);

            Console.ReadLine();
        }
    }
}
