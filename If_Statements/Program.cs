using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine();

            Console.WriteLine("Your name is " + name + " and your age is " + age);

            /* 
             * Comparison operators
             * == equal
             * > greater
             * >= greater or equal
             * < lesser
             * <= lesser or equal
             * != not equal
             * || or
             * && and
            */
            
            /*
            if (age >= 18 && age <= 25) // 18 > 18
            {
                Console.WriteLine("You are between 18 and 25");
            }
            else if (age >= 26)
            {
                Console.WriteLine("You are 26 or older");
            }

            // Range checking using or
            if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age!");
            }
            else
            {
                Console.WriteLine("Valid Age!");
            }
            */

            // Let combine the above if/else checking
            if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age!");
            }
            else
            {
                if (age >= 18 && age <= 25) // 18 > 18
                {
                    Console.WriteLine("You are between 18 and 25");
                }
                else if (age >= 26)
                {
                    Console.WriteLine("You are 26 or older");
                }
            }
            
            Console.WriteLine();


            Console.Write("Enter the first number: ");
            string firstNumber = Console.ReadLine();
            int numberA = Convert.ToInt32(firstNumber);

            Console.Write("Enter the second number: ");
            string secondNumber = Console.ReadLine();
            int numberB = Convert.ToInt32(secondNumber);

            int answer = numberA * numberB;

            Console.Write("Value of " + numberA + " x " + numberB + ": ");
            string answerInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerInput);

            if (answer == actualAnswer)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            Console.ReadLine();
        }
    }
}
