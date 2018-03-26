using System;

class ratedR
{
	static void Main() 
	{
		Console.WriteLine("How old are you?");
		string ageString = Console.ReadLine();
		int age = int.Parse(ageString);

		if (age >= 17)
		{
			Console.WriteLine("Great you can see the movie");
		}
		else
		{
			Console.WriteLine("Sorry you are too young to see the movie.");
		}

	}
	
}