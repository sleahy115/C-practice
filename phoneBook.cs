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
				LookUpContact();
			}
			else 
			{
				Console.WriteLine("Would you like to remove a contact from the phone book?y/n");
				string remove = Console.ReadLine();
				remove = remove.ToLower();
				if(remove == "y")
				{
					RemoveContact();
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
		Main();
	}

	static void RemoveContact()
	{
		Console.WriteLine("Remove Contact");
		Console.WriteLine("Enter the name of the contact you would like to remove");
		string removedContact = Console.ReadLine();
		 if(phoneNumbers.ContainsKey(removedContact))
		 {
		 	phoneNumbers.Remove(removedContact);
		 	Console.WriteLine(removedContact + "has been removed from the phone book");
		 }
		 Main();
	}

	static void LookUpContact()
	{
		Console.WriteLine("Look up contact");
		Console.WriteLine("Please enter the name of the contact");
		string friend = Console.ReadLine();

		if(phoneNumbers.ContainsKey(friend))
		{
			string value = phoneNumbers[friend];
			Console.WriteLine(friend + "'s number is " + value);
		}
		else 
		{
			Console.WriteLine("Sorry your friend is not in the phone book. Would you like to add them? y/n");
			string addFriend = Console.ReadLine();
			addFriend = addFriend.ToLower();
			if(addFriend == "y")
			{
				AddContact();
			}
			else
			{
				Main();
			}
		}
		Main();
	}
}
