using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            // Convert for loop to while loop
            // while(condition) { do something } 

            /*
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            */

            Console.Write("Enter the first number: ");
            string firstNumber = Console.ReadLine();
            int numberA = Convert.ToInt32(firstNumber);

            Console.Write("Enter the second number: ");
            string secondNumber = Console.ReadLine();
            int numberB = Convert.ToInt32(secondNumber);

            int answer = numberA * numberB;
            int actualAnswer = 0;
            Console.WriteLine();


            Console.Write("What is the value of " + numberA + " x " + numberB + "? ");
            Console.WriteLine();

            /*
             * While loop
            /*
            while (answer != actualAnswer)
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (answer == actualAnswer)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

            }
            */

            /*
             * Do While loops
             */
            do
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (answer != actualAnswer)
                {
                    Console.WriteLine("Wrong!");
                    Console.WriteLine();
                }

            } while (answer != actualAnswer);

            Console.WriteLine("Well Done!");

            Console.ReadLine();
        }
    }
}
