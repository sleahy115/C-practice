using System;
using System.Collections.Generic;

public class Car
{
	private string _make;
	private string _model;
	private int _year;
	private int _mileage;
	private int _price;

	public void SetMake(string newMake)
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

	
	public string GetModel()
	{
		return _model;
	}

	public void SetYear(int newYear)
	{	
		if(newYear >= 1885)
		{
			_year = newYear;
		}
		else
		{
			Console.WriteLine("Sorry the year must be later than 1885!");
		}
	}

	public int GetYear()
	{
		return _year;
	}

	public void SetMileage(int newMileage)
	{
		if(newMileage >=0)
		{
			_mileage = newMileage;
		}
		else
		{
			Console.WriteLine("Sorry the value must be greater than 0");
		}
	}

	public int GetMileage()
	{
		return _mileage;
	}

	public void SetPrice(int newPrice)
	{
		if(newPrice >=0)
		{
			_price = newPrice;
		}
		else
		{
			Console.WriteLine("Sorry the price must be greater than 0");
		}
	}

	public int GetPrice()
	{
		return _price;
	}	


	public bool WorthBuying(int maxPrice, int maxMiles)
	{
		return(GetPrice() < maxPrice && GetMileage() < maxMiles);
	}
}

public class Program
{
	static void Main()
	{
		Car Ford = new Car();
		Ford.SetMake("Ford");
		Ford.SetModel("Tarus");
		Ford.SetYear(2016);
		Ford.SetMileage(10000);
		Ford.SetPrice(10000);

		Car Mazda = new Car();
		Mazda.SetMake("Mazda");
		Mazda.SetModel("3");
		Mazda.SetYear(2018);
		Mazda.SetMileage(100);
		Mazda.SetPrice(20000);

		Car Porsche = new Car();
		Porsche.SetMake("Porsche");
		Porsche.SetModel("Cayenne");
		Porsche.SetYear(2017);
		Porsche.SetMileage(3000);
		Porsche.SetPrice(35000);

		List<Car> Car = new List<Car>() { Ford, Mazda, Porsche };
		foreach(Car auto in Car)
		{
			Console.WriteLine(auto.GetMake());
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

			if(CarsMatching.Count == 0)
			{
				Console.WriteLine("Sorry no matching cars, would you like to search again? y/n");
				string searchAgain = Console.ReadLine();
				if(searchAgain == "y")
				{
					Main();
				}
				else 
				{
					Console.WriteLine("Thank you!");
				}

			}
			else
			{
				foreach(Car vehicle in CarsMatching)
				{
					Console.WriteLine("The vehicle make is " + vehicle.GetMake());
					Console.WriteLine("The vehicle mileage is " + vehicle.GetMileage());
					Console.WriteLine("The vehicle price is " + vehicle.GetPrice());
				}
				Console.WriteLine("Would you like to search again? y/n");
				string searchAgain = Console.ReadLine();
				if(searchAgain == "y")
				{
					Main();
				}
				else 
				{
					Console.WriteLine("Thank you!");
				}
			}	
	}	}
}