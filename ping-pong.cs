using System;

class PingPong
{
	static void main ()
	{
		Console.WriteLine = "Please enter a number and we will play ping pong";
		int number =  Console.ReadLine();

		for(int index = 0; index < number.length; index ++)
		{
			if (number % 3 = 0)
			{
				Console.WriteLine("ping");
			}
			else if (number % 5 = 0)
			{
				Console.WriteLine("pong");
			}
			else
			{
				Console.WriteLine(number);
			}
			
		}
	}
	
}
