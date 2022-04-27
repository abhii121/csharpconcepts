using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleprgm
{
    internal class PassByValueRef
    {
        int a;
        int b;
        public void Swap(int x, int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("After Swap: " + x);
            Console.WriteLine("After Swap: " + y);
        }
    }
    public class PassByRefVal
    {
        public static void Main()
        {
            PassByValueRef passByValueRef = new PassByValueRef();
            int a = 10; 
            int b = 20;
            Console.WriteLine("Before Swap: " + a);
            Console.WriteLine("Before Swap: " + b);
            passByValueRef.Swap(a, b);
            Console.WriteLine("After Swap: " + a);
            Console.WriteLine("After Swap: " + b);
        }
    }
}