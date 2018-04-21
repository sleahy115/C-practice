using System;

class LeapYear
{
	static void Main()
	{
		Console.WriteLine("What year were you born in?");
		string birthYearString = Console.ReadLine();
		int birthYear = int.Parse(birthYearString);

		Console.WriteLine("You were alive during the following leap years: ");
		for (int year = birthYear; year <= 2018; year++)
		{
			if (year % 4 == 0)
			{
				Console.WriteLine(year);
			}
		}
	}
}	