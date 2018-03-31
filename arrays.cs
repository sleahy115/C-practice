using System;

class Array

{
	static void Main()
	{
		string[] fruits = {"apple", "grape", "grapefruit"};
		string[] badFruits = {"Bannana", "blueberry", "durien"};
		int[] numbers = {3, 6, 9, 1};
		string replaced = fruits[2].Replace(fruits[2], badFruits[2]);
		int multiplied = numbers[1] * 5;

		Console.WriteLine("My favorite fruit is " + fruits[2]);
		Console.WriteLine("My favorite number is " + numbers[1]);
		Console.WriteLine("My least favorite fruit is " + replaced);
		Console.WriteLine("My favorite number multiplied by 5 is " + multiplied);
	}
}