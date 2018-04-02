using System;

class GroceryList

{
	static void Main()
	{
		string[] myGroceries = {"eggs", "milk", "fruit"};
		int[] groceryPrices = {3,5, 10};
		int total = 0;
		Console.WriteLine("Your grocery list is:");
		foreach(string groceryItem in myGroceries)
		{
			Console.WriteLine(groceryItem);
		} 
		foreach(int price in groceryPrices)
		{
			total= total + price;
		}

		Console.WriteLine("Your groceries will cost " + total);

	}
}