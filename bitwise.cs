using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconcepts
{
    internal class bitwise
    {
        public static void Main()
        {
            int num1 = 20;
            int num2 = 30;
            int num3;
            num3 = num1 | num2;
            Console.WriteLine(num3);
            num3 = num1 & num2;
            Console.WriteLine(num3);
            num3 = num1 ^ num2;
            Console.WriteLine(num3);
            int num4 = 70;
            Console.WriteLine(~num4);
        }
    }
}
