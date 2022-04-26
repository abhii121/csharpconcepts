using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconcepts
{
    internal class @delegate
    {
       public class Rectangle
        {
            public void GetArea(double Width, double Height)
            {
                Console.WriteLine(@"Area is {0}", (Width * Height));
            }
            public void GetPerimeter(double Width, double Height)
            {
                Console.WriteLine(@"Perimeter is {0}", (2 * (Width + Height)));
            }
            static void Main(string[] args)
            {
                Rectangle rect = new Rectangle();
                rect.GetArea(29.45, 67.89);
                rect.GetPerimeter(29.45, 67.89);
                Console.ReadKey();
            }
        }
    }
}

