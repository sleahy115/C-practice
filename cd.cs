using System;
using System.Collections.Generic;

class Cd
{
	public string Title;
	public string Artist;
	public int Year;
	public double Price;
	
	public Cd(string albumTitle, string albumArtist, int albumYear, double albumPrice = 19.99)
	{
		Title = albumTitle;
		Artist = albumArtist;
		Year = albumYear;
		Price = albumPrice;
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

		List<Cd> Cds = new List<Cd>() {firstCd, secondCd, thirdCd};
		Cds.Add(forthCd);

		foreach(Cd album in Cds) 
		{
			Console.WriteLine (album.Title);
			Console.WriteLine ("By: " + album.Artist);
			Console.WriteLine ("Year: " + album.Year);
			Console.WriteLine ("Price: " + album.Price);
		}

	}

}