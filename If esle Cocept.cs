using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconcepts
{
    internal class If_esle_Cocept
    {
        public static double Average(double n1, double n2, double n3)
        {
            double avrg = (n1 + n2 + n3) / 3;
            return avrg;
        }
        static void Main(string[] args)
        {
            double num1, num2, num3;
            double avg;
            Console.Write("Number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 3: ");
            num3 = Convert.ToDouble(Console.ReadLine());
            avg = Average(num1, num2, num3);
            Console.WriteLine("The average of three numbers is " + avg);
            Console.ReadKey();
        }



    }
}
