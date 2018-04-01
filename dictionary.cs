using System;
using System.Collections.Generic;

class Dictionary

{
	static void Main()
	{
		Dictionary<string, string> myDictionary = new Dictionary<string, string>()
		{{"A", "Apple"},{"B", "Berry"}};
		Dictionary<string, int> cakeOrder = new Dictionary<string, int>()
		{{"Vanilla", 15}, {"Chocolate", 12},{"Red Velvet", 14}};

		myDictionary["C"] ="Cantaloupe";

		Console.WriteLine(myDictionary["A"]);
		Console.WriteLine(cakeOrder["Vanilla"]);
		Console.WriteLine(cakeOrder["Red Velvet"]);
		Console.WriteLine(myDictionary["C"]);

	}
}