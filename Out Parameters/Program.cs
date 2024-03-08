using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            test(out num);
            //bool success = test(out num);

            Console.WriteLine(num);
            //Console.WriteLine(success);

            //int.TryParse("123", out int result);
            //int.TryParse()

            List<string> shoppingList = new List<string>
            {
                "Coffee", "Milk"
            };

            Console.WriteLine(shoppingList.IndexOf("Milk"));
            //Console.WriteLine(FindInList("Coffee", shoppingList, out int index));
            //Console.Write(index);

            Console.Write("Enter an item to search: ");
            string search = Console.ReadLine();

            if (FindInList(search, shoppingList, out int index))
            {
                Console.WriteLine($"Found {search} at index {index}");
            }
            else
            {
                Console.WriteLine($"Not found");
            }

            /*
            int index = -1; // 0 -> higher

            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (shoppingList[i].ToLower().Equals("milk"));
                {
                    index = i;
                }
            }

            Console.WriteLine(index);

            bool found = index > -1;

            Console.WriteLine(found ? "Found" : "Not found");
            */

            Console.ReadLine();
        }


        static bool FindInList(string search, List<string> list, out int index)
        {
            index = -1; // 0 -> higher

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(search.ToLower()))
                {
                    index = i;
                }
            }

            //bool found = index > -1;

            return index > -1;
        }

        static void test(out int num)
        {
            //num = 5;
            //Console.WriteLine($"");
            num = 5;
            //return true;
        }

        static bool TryParse(string s, out int result)
        {
            result = 0;
            return true;
        }
    }
}
