using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Will get overflow, if user enter number bigger than the max Int32.
            // Have to manually handle the exception, otherwise the program crash
            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
