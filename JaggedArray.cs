using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconcepts
{
    internal class JaggedArray
    {
        public static void Main()
        {
            int[][] jarray = new int[3][]
            {
                new int[2] {1,2 },
                new int[3] {1,2,3},
                new int[4] {1,2,3,4}
            };
            Console.WriteLine("Elements are :");
            for (int i = 0; i < jarray.Length; i++) 
            {
                for (int j = 0; j < jarray[i].Length; j++) 
                {
                    Console.Write(jarray[i] [j]);
                    Console.Write("\t");


                }
                Console.WriteLine();
            }

        }
    }
}
