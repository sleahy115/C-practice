using System;
using System.Collections.Generic;

public class Car
{
	public string Make;
	public string Model;
	public int Year;
	public int Mileage;
}

public class Program
{
	public static void Main()
	{
		Car Ford = new Car();
		Ford.Make = "Ford";
		Ford.Model = "Tarus";
		Ford.Year = 2016;
		Ford.Mileage = 10000;

		Car Mazda = new Car();
		Mazda.Make = "Mazda";
		Mazda.Model = "3";
		Mazda.Year = 2018;
		Mazda.Mileage = 100;

		Car Porsche = new Car();
		Porsche.Make = "Porsche";
		Porsche.Model = "Cayenne";
		Porsche.Year = 2017;
		Porsche.Mileage = 3000;

		List<Car> Car = new List<Car>() { Ford, Mazda, Porsche };
		foreach(Car auto in Car)
		{
			Console.WriteLine(auto.Make);
		}
	}
}