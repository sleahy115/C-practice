using System;
using System.Collections.Generic;

public class Car
{
	private string _make;
	private string _model;
	private int _year;
	private int _mileage;
	private int _price;

	public void SetMake(string newmake)
	{
		_make = newMake;
	}

	public string GetMake()
	{
		return _make;
	}

	public void SetModel(string newModel)
	{
		_model = newModel;
	}

	public string SetMake(string newMake)
	{
		return _make;
	}

	public void SetYear(int newYear)
	{
		_year = newYear;
	}

	public int GetYear()
	{
		return _year;
	}

	public void SetMileage(int newMilage)
	{
		_mileage = newMileage;
	}

	public int GetMileage()
	{
		return _mileage;
	}

	public void SetPrice(int newPrice)
	{
		_price = newPrice;
	}

	public int GetPrice()
	{
		return _price;
	}	


	public bool WorthBuying(int maxPrice, int maxMiles)
	{
		return(Price < maxPrice && Mileage < maxMiles);
	}
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
		Ford.Price = 10000;

		Car Mazda = new Car();
		Mazda.Make = "Mazda";
		Mazda.Model = "3";
		Mazda.Year = 2018;
		Mazda.Mileage = 100;
		Mazda.Price = 20000;

		Car Porsche = new Car();
		Porsche.Make = "Porsche";
		Porsche.Model = "Cayenne";
		Porsche.Year = 2017;
		Porsche.Mileage = 3000;
		Porsche.Price = 35000;

		List<Car> Car = new List<Car>() { Ford, Mazda, Porsche };
		foreach(Car auto in Car)
		{
			Console.WriteLine(auto.Make);
		}
		Console.WriteLine("Enter maximum mileage");
		string maxMilesString = Console.ReadLine();
		int maxMiles = int.Parse(maxMilesString);

		Console.WriteLine("Enter maximum price");
		string maxPriceString = Console.ReadLine();
		int maxPrice = int.Parse(maxPriceString);

		List<Car> CarsMatching = new List<Car>();
		foreach(Car auto in Car)
		{
			if (auto.WorthBuying(maxPrice, maxMiles))
			{
				CarsMatching.Add(auto);
			} 	
		}	
		foreach(Car vehicle in CarsMatching)
		{
			Console.WriteLine("The vehicle make is " + vehicle.Make);
			Console.WriteLine("The vehicle mileage is " + vehicle.Mileage);
			Console.WriteLine("The vehicle price is " + vehicle.Price);
		}
	}
}