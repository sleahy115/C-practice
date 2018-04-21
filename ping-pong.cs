using System;

class PingPong
{
	static void Main()
	{
		Console.WriteLine("Please enter a number and we will play ping pong");
		string numberString =  Console.ReadLine();
		int number = int.Parse(numberString);

		for(int index = 1; index < number; index ++)
		{
			if (index % 3 == 0)
			{
				Console.WriteLine("ping");
			}
			else if (index % 5 == 0)
			{
				Console.WriteLine("pong");
			}
			else
			{
				Console.WriteLine(index);
			}
			
		}
	}
	
}
