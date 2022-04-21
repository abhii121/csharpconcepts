using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconcepts
{
    internal class null_coalescing
    {

        static void Main(string[] args)
        {
            double? num1 = null;
            double? num2 = 6.32123;
            double num3;

            num3 = num1 ?? 9.77;
            Console.WriteLine(" Value of num3: {0}", num3);

            num3 = num2 ?? 9.77;
            Console.WriteLine(" Value of num3: {0}", num3);
            Console.ReadLine();
        }
    }
}
