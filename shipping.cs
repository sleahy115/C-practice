using System;

class ShippingPrice

{
	static void Main() 
	{
		Console.WriteLine("Please enter the weight if the Item");
		string weightString = Console.ReadLine();
		int weight = int.Parse(weightString);
		Console.WriteLine("Please enter the distance the item will travel in miles");
		string distanceString = Console.ReadLine();
		int distance = int.Parse(distanceString);
		int priceFactor = 5;
		int price = weight / 10 + distance / 5 * priceFactor;
		Console.WriteLine("The price for shipping your item is: " + price); 
	}
}