using System; 

class startsWith

{
	static void Main()
	{
		Console.WriteLine("What is your name?");
		string userName = Console.ReadLine();

		if(userName.StartsWith("Z"))
		{
			Console.WriteLine("Like Zorro you are awesome!");
		}
		else
		{
			Console.WriteLine("You are awesome, but your name will never be cool like Zorro :(");
		}
	}
}