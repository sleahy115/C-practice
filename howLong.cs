using System;

class HowLong
{
	static void Main()
	{
		Console.WriteLine("How many days will it take you to get to 10,000 hours of practice?");
		Console.WriteLine("How many hours a day will you practice?");
		string hoursString = Console.ReadLine();
		int hoursNum = int.Parse(hoursString);
		int days = 10000 / hoursNum;
		int years = days/365;

		Console.WriteLine("It will take you " + days + " days to become an expert!");
		Console.WriteLine("That is " + years + " years if you practice every day");
	}
	
}
