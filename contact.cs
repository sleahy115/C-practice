using System;
using System.Collections.Generic;

public class Contact 
{
	public string Name;
	public string Phone;
	public string Email;
}

class Program 
{
	public static void Main()
	{
		Contact Bob = new Contact();
		Bob.Name = "Bob Smith";
		Bob.Phone = "123-456-7890";
		Bob.Email = "Bob@bob.com";

		Contact Jane = new Contact();
		Jane.Name = "Jane Johnson";
		Jane.Phone = "234-567-8900";
		Jane.Email = "Jane@jane.com";

		Contact Melissa = new Contact();
		Melissa.Name = "Melissa Brooks";
		Melissa.Phone = "223-445-6678";
		Melissa.Email ="Melissa@melissa.com";

		List<Contact> AddressBook = new List<Contact>() { Bob, Jane, Melissa };
		foreach(Contact person in AddressBook)
		{
			Console.WriteLine("Name : " + person.Name);
			Console.WriteLine("Phone number: " + person.Phone);
			Console.WriteLine("Email: " + person.Email);
		}
	}
}