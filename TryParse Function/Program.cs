using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sucess = true;

            while (sucess)
            {
                Console.Write("Enter a number: ");
                string numInput = Console.ReadLine();   // 10h?

                if (int.TryParse(numInput, out int num))
                {
                    sucess = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to convert!");
                }
            }
            //Console.WriteLine(num);


            Console.ReadLine();
        }
    }
}
