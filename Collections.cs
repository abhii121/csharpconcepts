using System;
using System.Collections.Generic;
using System.Collections;

class collections1
{
	static public void Main()
	{
	
		Dictionary<string, string> My_dict = new Dictionary<string, string>();
		My_dict.Add("a.01", "C");
		My_dict.Add("a.02", "C++");
		My_dict.Add("a.03", "C#");

		foreach (KeyValuePair<string, string> element in My_dict)
		{
			Console.WriteLine("Key:- {0} and Value:- {1}",element.Key, element.Value);
		}

		Hashtable my_hashtable = new Hashtable();
		my_hashtable.Add("A1", "Welcome");
		my_hashtable.Add("A2", "to");
		my_hashtable.Add("A3", "Bangalore");

		foreach (DictionaryEntry element in my_hashtable)
		{
			Console.WriteLine("Key:- {0} and Value:- {1} ",
							   element.Key, element.Value);
		}
	}
}
