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
		if(age >13)
		{
			Console.WriteLine("Do you have permission from your parents? yes or no");
			string permission = Console.ReadLine();
			if (permission == "yes")
			{
				Console.WriteLine("OK enjoy the movie");
			}
			else
			{
				Console.WriteLine("Sorry you need your parent's permission first.");
			}
		}

	}
	
}