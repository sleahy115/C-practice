using System;
using System.Collections.Generic;

class Cd
{
	private string _title;
	private string _artist;
	private int _year;
	private double _price;
	
	public Cd(string albumTitle, string albumArtist, int albumYear, double albumPrice = 19.99)
	{
		_title = albumTitle;
		_artist = albumArtist;
		_year = albumYear;
		_price = albumPrice;
	}

	public void SetTitle(int newTitle)
	{
		_title = newTitle;
	}

	public void GetTitle()
	{
		return _title;
	}

	public void SetArtist(int newArtist)
	{
		_artist = newArtist;
	}

	public void GetArtist()
	{
		return _artist;
	}

	public void SetYear(int newYear)
	{
		_year = newYear;
	}

	public void GetYear()
	{
		return _year;
	}

	public void SetPrice(int newPrice)
	{
		_price = newPrice;
	}

	public void GetPrice()
	{
		return _price;
	}
}


public class Program 
{
	public static void Main()
	{
		Cd firstCd = new Cd("Music for the ages", "Someone really good", 1984);
		Cd secondCd = new Cd("Pop stars", "Someone really bad", 2002);
		Cd thirdCd = new Cd("Heavy Metal", "Metal head", 2014, 12.95);
		Cd forthCd = new Cd("Classical", "Someone dead now", 1946);
		Cd fifthCd = new Cd("this should fail", "hope it does", 2002);

		List<Cd> Cds = new List<Cd>() {firstCd, secondCd, thirdCd};
		Cds.Add(forthCd);

		foreach(Cd album in Cds) 
		{
			Console.WriteLine (album._title);
			Console.WriteLine ("By: " + album.Artist);
			Console.WriteLine ("Year: " + album.Year);
			Console.WriteLine ("Price: " + album.Price);
		}

	}

}