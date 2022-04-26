using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconcepts
{
    internal class Dictionary_And_Hastable
    {
        public static void Main()
        {

        }
        public static void Dictionarydemo()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("F", "Football");
            dictionary.Add("C", "Cricket");
            dictionary.Add("C", "Hockey");
            dictionary.Add("K", "Kabadi");
            Console.WriteLine("Keys in the Dictionary");
            var key=new List<string>(dictionary.keys);
            foreach (var k in key)
            {

            }
        }
    }
}
