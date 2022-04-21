using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconcepts
{
    internal class params_array
    {
        public static int Add(params int[] ListNumbers)
        {
            int total = 0;
            foreach (int i in ListNumbers)
            {
                total += i;
            }
            return total;
        }  
        static void Main(string[] args)
        {
            int y = Add(12, 13, 10, 15, 56);
            Console.WriteLine(y);
        }
    }
}
