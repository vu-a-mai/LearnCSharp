using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verbatim_String_Literal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  /t  - Tab
             *  /n  - New Line
             *  \"  - Escape character to print "
             *  \\  - \
             */

            string speech = "He said \"something\"";
            string path = "C:\\User\\Vu\\Desktop\\Learn C#\nNew line test";
            Console.WriteLine(path);
            Console.WriteLine(speech);

            // $ +
            // $"Your name is {name}"
            // $"Your name is " + name

            // using verbatim identifier (@) to take care of escape character
            // only work on the assigned string
            path = @"C:\User\Vu\Desktop\Learn C#" + "\nNew line test";
            Console.WriteLine(path);

            // need to use double "" on both side when using @ identifier
            string name = @"Hello ""someone""";
            Console.WriteLine(name);

            name = "Hello 'someone'";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
