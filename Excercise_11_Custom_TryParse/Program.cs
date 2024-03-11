using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_11_Custom_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a int and try to convert any string to an int
             * Notice the error, write a try...catch handler around it
             * Catch the error and output the error message
             * Without changing the current code
             * 
             * Why is this a bad situation and how can we know if its been converted?
             * 
             * Create a  custom try parse function
             * Find the real function and copy return/params
             * Read the tooltip it gives you, to give you an ideas on what to do
             */

            /*
            bool success = false;

            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                success = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(success ? "Yes" : "Oh no, something went wrong!");

            */
            Console.Write("Enter a number: ");
            // Custom TryParse()
            if (TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Oh no, something went wrong!");
            }
            

            Console.ReadLine();
        }

        // Custom TryParse function
        static bool TryParse(string input, out int result)
        {
            result = -1;
            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            //catch (FormatException)
            //{
            //    return false;
            //}
            //catch (OverflowException)
            //{
            //    return false;
            //}
            catch (Exception)
            {
                return false;
            }
        }
    }
}
