using System;

class GroceryList

{
	static void Main()
	{
		string[] myGroceries = {"eggs", "milk", "fruit"};
		Console.WriteLine("Your grocery list is:");
		foreach(string groceryItem in myGroceries)
		{
			Console.WriteLine(groceryItem);
		} 
	}
}