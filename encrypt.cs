using System;

class Encrypt

{
	static void Main()
	{
		Console.WriteLine("Enter a phrase to encrypt");
		string phrase = Console.ReadLine();
		phrase = phrase.ToLower().Replace("a","1").Replace("e", "2").Replace("i", "3")
		.Replace("o", "4").Replace("u", "5").Replace("y", "!");
		Console.WriteLine("Your encrypted phrase is: " + phrase);
	}
}