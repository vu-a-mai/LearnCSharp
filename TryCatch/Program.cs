using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Example: try enter [] instead of an integer
            // Console.Write("Enter a number: ");
            // int num = Convert.ToInt32(Console.ReadLine());

            // System.FormatException
            // System.OverflowException

            bool looping = true;

            while (looping)
            {

                try
                {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);

                    looping = false;

                }
                // Catch a specific exception, too big or too small
                catch (OverflowException)
                {
                    Console.WriteLine("Please only enter a number less than 2 billion!");
                    //looping = true;
                }
                // Catch a specific exception, which is not a number/wrong format
                catch (FormatException)
                {
                    Console.WriteLine("Please only enter numbers!");
                    //looping = true;
                }
                // Catch all exception at the end
                catch (Exception)
                {
                    Console.WriteLine("Something has went wrong!");
                    //looping = true;
                }
            }



            Console.WriteLine("Goodbye!");

            Console.ReadLine();
        }
    }
}
