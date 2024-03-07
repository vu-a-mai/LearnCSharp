using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Dictionary<int, string> names = new Dictionary<int, string>();

            names.Add(1, "John");
            names.Add(2, "Abe");
            names.Add(3, "Tony");
            */

            /*
            Dictionary<int, string> names = new Dictionary<int, string>
            {
                
                // Key Value Pair
                // Value can be the same, but the key cannot
                
                {1, "John" },
                {2, "Aba" },
                {3, "Tony" },
            };

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            foreach (KeyValuePair<int, string> item in names)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            */

            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                { "Math", "John" },
                { "Science", "Tony" }
            };

            //Console.WriteLine(teachers["math"]);    //int.TryParse Convert

            if(teachers.TryGetValue("Math", out string teacher)) 
            {
                Console.WriteLine(teacher);
                teachers["Math"] = "Joe";
            }
            else
            {
                Console.WriteLine("Math teacher not found");
            }

            if (teachers.ContainsKey("Math"))
            {
                // remove, pass in the key
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("Math not found");
            }

            foreach (var item in teachers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.ReadLine();
        }
    }
}
