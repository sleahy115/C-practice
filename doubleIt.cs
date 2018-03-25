using System;

class DoubleIt

{
	static void Main()
	{
		Console.WriteLine("Give me a number and I will double it");
		string stringNumber = Console.ReadLine();
		int yourNumber = int.Parse(stringNumber);
		int doubleNumber = yourNumber * 2;
		string doubleNumberString = doubleNumber.ToString();
		Console.WriteLine(" Your number doubled is:" + doubleNumberString); 
	}
}
