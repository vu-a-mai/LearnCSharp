using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textAge = "-23";
            
            // Convert textAge to Int32
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNumber = "-900000000";
            // Convert textBigNumber to Int64
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            string textNegative = "-55.2";
            // Convert negative to Double
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);

            string textPrecision = "5.000001";
            // Convert precision to Float
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);

            string textMoney = "14.99";
            // Convert money to Decimal
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);

            Console.ReadLine();
        }
    }
}
