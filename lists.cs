using System;
using System.Collections.Generic;
// using System.Linq;

class Lists

{
	static void Main()
	{
		List<string> groceryList = new List<string> {};
		groceryList.Add("toothpaste");
		groceryList.Add("sparkling water");
		groceryList.Add("pasta");
		groceryList.Add("shrimp");
		groceryList.Remove("sparkling water");

		Console.WriteLine(groceryList[1]);
	}
}