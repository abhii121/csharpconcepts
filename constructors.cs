using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconcepts
{
    internal class constructors
    {
		class ADD
		{
			int x, y;
			double f;
			string s;
			//1st Constructor
			public ADD(int a, double b)
			{
				x = a;
				f = b;
			}//2nd Constructor
			public ADD(int a, string b)
			{
				y = a;
				s = b;
			}
			//1st Constructor show()
			public void show() 
			{
				Console.WriteLine("1st constructor (int + float): {0} ",(x + f));
			}
			//2nd Constructor show()
			public void show1()
			{
				Console.WriteLine("2nd constructor (int + string): {0}",(s + y));
			}
		}
		class GFG
		{

			// Main Method
			static void Main()
			{
				ADD g = new ADD(10, 20.2);
				g.show();
				ADD q = new ADD(10, "Roll No. is ");

				// calling the method
				q.show1();
			}
		}

	}
}
