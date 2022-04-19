using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconcepts
{
    internal class Arrays
    {
        public static void Main()
        {
            Array2D();
            Jagged_array();

        }
        public static void Array2D()
        {
            int[,] array = new int[,]
            {
                {1,2,3 },
                {4,5,6}
            };
            Console.WriteLine("Elements in 2D array");
            for (int i = 0; i < 2; i++) 
            {
                for (int j = 0; j < 3; j++) 
                {
                    Console.Write(array[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();

            }


        }
        public static void Jagged_array()
        {
            int[][] jarray = new int[3][]
            {
                new int[2]{1,2},
                new int[3]{1,2,3},
                new int[4]{1,2,3,4}
            };
            Console.WriteLine("Elements in Jagged array");
            for (int i=0;i<jarray.Length;i++)
            {
                for (int j=0;j<jarray[i].Length;j++)
                {
                    Console.WriteLine(jarray[i][j]);
                    Console.WriteLine("\t");
                }
                Console.WriteLine();
            }
        }
    }
}
