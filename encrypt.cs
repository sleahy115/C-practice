using System;

class Encrypt

{
	static void Main()
	{
		Console.WriteLine("Enter a phrase to encrypt");
		string phrase = Console.ReadLine();
		string encryptedPhrase = phrase.Replace("e", "o");
		string encryptedPhrase2 = encryptedPhrase.Replace("a", "1");
		Console.WriteLine("Your encrypted phrase is: " + encryptedPhrase2);
	}
}