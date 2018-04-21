using System;
using System.Collections.Generic;

public Class Contact 
{
	public string Name;
	public sting Phone;
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
		Melissa.Email ="Melissa@melissa.com"
	}
}