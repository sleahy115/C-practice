using System;

class AlwaysOne

{
	static void Main()
	{
		Console.WriteLine("Please enter a number and I will convert it into the best number");
		string yourNumberString = Console.ReadLine();
		int yourNumber = int.Parse(yourNumberString);
		int bestNumber = yourNumber / yourNumber;
		string bestNumberString = bestNumber.ToString();

		Console.WriteLine("Your number was:" + yourNumberString + "now it has been improved to:" 
		+ " " + bestNumberString);
	}
}