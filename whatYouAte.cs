using System;

class MealTime 
{
	static void Main() 
	{
		AskWhatYouAteFor("Breakfast");
		AskWhatYouAteFor("Lunch");
		AskWhatYouAteFor("Dinner");
	}

	static void AskWhatYouAteFor(string meal)
	{
		Console.WriteLine("What did you eat for " + meal);
		string yourMeal = Console.ReadLine();
		Console.WriteLine("You ate " + yourMeal + " for " + meal);

	}
	
}