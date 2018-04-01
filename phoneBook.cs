using System;
using System.Collections.Generic;

class PhoneBook

{
	public static Dictionary<string,string> phoneNumbers = new Dictionary<string, string>();
	
	static void Main()
	{
		Console.WriteLine("Would you like to add a contact to the phone book?y/n");
		string response = Console.ReadLine();
	    response = response.ToLower();

		if(response == "y")
		{
			AddContact();
		}
		else
		{
			Console.WriteLine("Would you like to look up someone in the phone book? y/n");
			string lookUpResponse = Console.ReadLine();
			lookUpResponse = lookUpResponse.ToLower();

			if(lookUpResponse == "y")
			{
				// Console.WriteLine("Please enter the name of the person you would like to look up");
				LookUpContact();
			}
			else
			{
				Console.WriteLine("Are you finished with the phone book?y/n");
				string closeResponse = Console.ReadLine();
				closeResponse = closeResponse.ToLower();
				if(closeResponse == "y")
				{
					Console.WriteLine("Thanks for using the phone book.");
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
		Console.WriteLine("New Contact");
		Console.WriteLine("Please enter the contact's name");
		string name = Console.ReadLine();
		Console.WriteLine("Please enter the contact's phone number");
		string phoneNumber = Console.ReadLine();
		if (phoneNumbers.ContainsKey(name))
		{
			Console.WriteLine("This person is already in the phone book. Thier number is " +phoneNumbers[name]);
		}
		else
		{
			phoneNumbers.Add(name, phoneNumber);
		}
	}

	static void RemoveContact()
	{

	}

	static void LookUpContact()
	{
		Console.WriteLine("Look up contact");
		Console.WriteLine("Please enter the name of the contact");
		string friend = Console.ReadLine();
		if(phoneNumbers.ContainsKey(friend))
		{
			Console.WriteLine(friend + "'s number is " + phoneNumbers[friend]);
		}
	}
}
