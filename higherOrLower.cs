using System;
using System.Collections.Generic;

class HigherOrLower
{

	static void Main()
	{
		Random random = new Random();
		int number = random.Next(-500,500);
		Console.WriteLine(number);
		Console.WriteLine("Lets play a guessing game. I am thinking of a number between -500 and 500, Can you guess it? I will let you know if you are too high or too low.");
		string userGuessString = Console.ReadLine();
		int userGuess = int.Parse(userGuessString);
		if(userGuess < -500 || userGuess > 500)
		{
			Console.WriteLine("Sorry your number is outside of the number range. Please choose a number that is between -500 and 500"); 
		}
		else
		{
			if(userGuess == number)
			{
				Console.WriteLine("Amazing you guessed it. The number I was thinking of was " + number);
			}
			else if( userGuess > number)
			{
				Console.WriteLine("You are too high guess again.");
				Main();
			}
			else
			{
				Console.WriteLine("You are too low guess again");
				Main();
			}

		}
	}
}
