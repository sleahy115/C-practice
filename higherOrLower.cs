using System;
using System.Collections.Generic;

class HigherOrLower
{
		public static readonly Random random = new Random();
		public static int number = random.Next(-500,500);
		// public int userGuess = 0;

	static void Main()
	{
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
			Check(userGuess);
		}
	}

	static void Check(int userGuess)
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


