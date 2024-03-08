using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9_Area_of_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = ReadInt("width");
            int height = ReadInt("height");

            int result = CalculateAreaofTriangle(width, height);

            Console.WriteLine($"The area is {result}");

            Console.ReadLine();
            
        }

        static int CalculateAreaofTriangle(int width, int height)
        {
            return (width * height) / 2;
        }

        static int ReadInt(string message)
        {
            Console.Write($"Enter {message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
