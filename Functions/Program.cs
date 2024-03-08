using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Test
    {
        public static void someFunction()
        {
            Console.WriteLine("Some function");
        }

        public void differentFunction()
        {
            Console.WriteLine("Different function");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Call the function
            WelcomeMessage();

            // To use the function from class test
            // we can use it directly if it is static
            Test.someFunction();

            // If the function is not static
            // make the new instant of the class
            Test newTest = new Test();
            newTest.differentFunction();
            
            Console.ReadLine();
        }

        // Seperate function from the main function
        // Use static, we don't to create new instant
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome John");
        }
    }
}
