using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconcepts
{

		class GFG
		{
            public string? name;
            public string? subject;
			public void readers(string name, string subject)
			{
				this.name = name;
				this.subject = subject;
				Console.WriteLine("Myself: " + name);
				Console.WriteLine("My Favorite Subject is: " + subject);
			}
		}
    class DLithe : GFG
		{
			public DLithe()
			{
				Console.WriteLine("Dlithe Consultancy");
			}
		}

		// Driver class
		class Sudo
		{
        static void Main(string[] args)
			{
				DLithe g = new DLithe();
				g.readers("Abhi", "C#");
			}
		}
}


