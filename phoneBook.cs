using System;
using System.Collections.Generic;

class PhoneBook

{
	public static Dictionary<string,sting> phoneNumbers = new Dictionary<string, string>();
	
	static void Main()
	{
		Console.WriteLine("Would you like to add a contact to the phone book?y/n");
		string response = Console.ReadLine();
	    response = response.toLower();

		if(response == "y")
		{
			AddContact();
		}
		else
		{
			Console.WriteLine("Would you like to look up someone in the phone book? y/n");
			string lookUpResponse = Console.ReadLine();
			lookUpResponse = lookupResponse.toLower();

			if(lookUpResponse == "y")
			{
				// Console.WriteLine("Please enter the name of the person you would like to look up");
				LookUpContact();
			}
			else
			{
				Console.WriteLine("Are you finished with the phone book?y/n");
				string closeResponse = Console.Readline();
				closeResponse = closeResponse.toLower();
				if(closeResponse == "y")
				{
					Console.WriteLine("Thanks for using the phone book.")
				}
				else
				{
					Main();
				}
			}

		}
	}

	static void AddContact()
	{

	}

	static void RemoveContact()
	{

	}

	static void LookUpContact()
	{

	}
}
