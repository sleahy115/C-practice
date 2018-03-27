using System;

class Insurance
{
	static void Main()
	{
		Console.WriteLine("How old are you?");
		string ageString = Console.ReadLine(); 
		int age = int.Parse(ageString);
		Console.WriteLine("What sex are you? M/F");
		string sex = Console.ReadLine();
		sex = sex.ToLower();
		int quote = 50;
		if(age < 25 && sex == "m")
		{
			quote = quote * 4;
			Console.WriteLine("Your quote for auto insurance is " + quote);
		}
		else if(age < 25)
		{
			quote = quote * 2;
			Console.WriteLine("Your quote for auto insurance is " + quote);
		}
		else if(sex == "M")
		{
			quote = quote * 2;
			Console.WriteLine("Your quote for auto insurance is " + quote);
		}
		else
		{
			Console.WriteLine("Your quote for auto insurance is " + quote);
		}

	}
}