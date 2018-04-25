using System;

class Rectangle
{
	public int Length;
	public int Width;

	public bool IsSquare()
	{
		if(Length == Width)
		{
			return true;
		}
		else
		{
			return false;
		}	
	}
}

public class Program
{
	public static void Main()
	{
		Rectangle myRectangle = new Rectangle();

		Console.WriteLine("Enter the length of the shape");
		string lengthString = Console.ReadLine();
		int length = int.Parse(lengthString);
		myRectangle.Length = length;

		Console.WriteLine("Enter the width of the shape");
		string widthString = Console.ReadLine();
		int width = int.Parse(widthString);
		myRectangle.Width = width;

		if(myRectangle.IsSquare())
		{
			Console.WriteLine("It's a square!");
		}
		else
		{
			Console.WriteLine("Guess you are too hip to be square");
		}
	}
}

