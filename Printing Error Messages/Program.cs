using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Error_Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                Console.WriteLine("Please only enter numbers!");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                Console.WriteLine("Please enter a value under 2 billion!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.WriteLine("Goodbye!");

            Console.ReadLine();
        }
    }
}
