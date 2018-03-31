using System;
using System.Collections.Generic;

class Dictionary

{
	static void Main()
	{
		Dictionary<string, string> myDictionary = new Dictionary<string, string>()
		{{"A", "Apple"},{"B", "Berry"}};

		Console.WriteLine(myDictionary["A"]);

	}
}