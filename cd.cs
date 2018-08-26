using System;
using System.Collections.Generic;

class Cd
{
	public string Title;
	public string Artist;
	public int Year;
	public double Price;
}

public class Program 
{
	public static void Main()
	{
		Cd firstCd = new Cd();
		firstCd.Title = "Music for the ages";
		firstCd.Artist = "Someone really good";
		firstCd.Year = 1984;
		firstCd.Price = 19.99;

		Cd secondCd = new Cd();
		secondCd.Title = "Pop stars";
		secondCd.Artist = "Someone really bad";
		secondCd.Year = 2002;
		secondCd.Price = 11.99;

		Cd thirdCd = new Cd();
		thirdCd.Title = "Heavy Metal";
		thirdCd.Artist = "Metal head";
		thirdCd.Year = 2014;
		thirdCd.Price = 12.95;

		List<Cd> Cds = new List<Cd>() {firstCd, secondCd, thirdCd};

		foreach(Cd album in Cds) 
		{
			Console.WriteLine (album.Title);
			Console.WriteLine ("By: " + album.Artist);
			Console.WriteLine ("Year: " + album.Year);
			Console.WriteLine (" Price: " + album.Price);
		}

	}

}