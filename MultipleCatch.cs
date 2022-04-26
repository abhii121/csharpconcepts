using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconcepts
{
    internal class MultipleCatch
    {
        static void Main()
        {
            int[] number = { 2, 4, 6, 8, 10 };
            int[] divisor = { 2, 0, 0, 5 };

            for (int j = 0; j < number.Length; j++) 
            try
            {
                    Console.WriteLine("Number : " + number[j]);
                    Console.WriteLine("Divisor :" + divisor[j]);
                    Console.WriteLine("Quotient :"+ number[j]/divisor[j]);
             }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("Not possible to divide by zero");
                }
            catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Index is out of range");
                }

        }
    }
}
