using System;
using System.Linq;

class Potluck

{
	static void Main()
	{
		var guests = new[] {"Tom", "Dick", "Jane"};
		var foods = new[] {"apps", "main dish", "dessert"};
		var assignments = guests.Zip(foods, (g,f) => new {guest = g, food = f});

		foreach(var gf in assignments)
		{	
			Console.WriteLine(gf.guest + " will bring " + gf.food);
		}
	}
}