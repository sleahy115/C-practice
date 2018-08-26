using System;
using System.Collections.Generic;

class Cd
{
	private string _title;
	private string _artist;
	private int _year;
	private double _price;
	
	// public Cd(string albumTitle, string albumArtist, int albumYear, double albumPrice = 19.99)
	// {
	// 	_title = albumTitle;
	// 	_artist = albumArtist;
	// 	_year = albumYear;
	// 	_price = albumPrice;
	// }

	public void SetTitle(String newTitle)
	{
		_title = newTitle;
	}

	public string GetTitle()
	{
		return _title;
	}

	public void SetArtist(String newArtist)
	{
		_artist = newArtist;
	}

	public string GetArtist()
	{
		return _artist;
	}

	public void SetYear(int newYear)
	{
		_year = newYear;
	}

	public int GetYear()
	{
		return _year;
	}

	public void SetPrice(double newPrice)
	{
		if(newPrice >= 0)
		{
			_price = newPrice;
		}
		else
		{
			Console.WriteLine("Sorry the price must be greater than 0");
		}
	}

	public double GetPrice()
	{
		return _price;
	}
}


public class Program 
{
	public static void Main()
	{
		// Cd firstCd = new Cd("Music for the ages", "Someone really good", 1984);
		// Cd secondCd = new Cd("Pop stars", "Someone really bad", 2002);
		// Cd thirdCd = new Cd("Heavy Metal", "Metal head", 2014, 12.95);
		// Cd forthCd = new Cd("Classical", "Someone dead now", 1946);
		// Cd fifthCd = new Cd("this should fail", "hope it does", 2002);

		// List<Cd> Cds = new List<Cd>() {firstCd, secondCd, thirdCd};
		// Cds.Add(forthCd);

		// foreach(Cd album in Cds) 
		// {

			Cd sixthCd = new Cd();
			sixthCd.SetTitle("Boy bands of the 90s"); 
			sixthCd.SetArtist("Multiple");
			sixthCd.SetYear(1999);
			sixthCd.SetPrice(-22.50);

			Cd seventhCd = new Cd();
			seventhCd.SetTitle("Boy bands of the 90s"); 
			seventhCd.SetArtist("Multiple");
			seventhCd.SetYear(1999);
			seventhCd.SetPrice(-22.50);


			Console.WriteLine (seventhCd.GetTitle());
			Console.WriteLine ("By: " + seventhCd.GetArtist());
			Console.WriteLine ("Year: " + seventhCd.GetYear());
			Console.WriteLine ("Price: " + seventhCd.GetPrice());
		// }

	}

}