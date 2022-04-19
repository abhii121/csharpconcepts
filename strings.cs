using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconcepts
{
    internal class strings
    {
        public static void Main()
        {
            stringBuilder();
        }
        public static void stringBuilder()
        {
            StringBuilder sb=new StringBuilder("Welcome");
            Console.WriteLine(sb.ToString());
            sb.Append("Have a nice day!!");
            Console.WriteLine(sb.ToString());
            sb.Insert(7, " to bangalore ");
            Console.WriteLine(sb.ToString());
        }
    }
}
