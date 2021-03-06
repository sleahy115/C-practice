using System;
using System.Collections. Generic;

public class Animal
{
	public string Type;
	public string Breed;
	public string Name;
	public int Age;
	public bool Nutered;

	public bool IsCat(string Type)
	{
		if(Type == "Cat")
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}

class Program
{
	public static void  Main()
	{
		Animal Mutt = new Animal();
		Mutt.Type = "Dog";
		Mutt.Breed = "Mutt";
		Mutt.Name = "Rusty";
		Mutt.Age = 5;
		Mutt.Nutered = true;

		Animal Siamese = new Animal();
		Siamese.Type = "Cat";
		Siamese.Breed = "Siamese";
		Siamese.Name = "King";
		Siamese.Age = 2;
		Siamese.Nutered = false;

		Animal Egyptian = new Animal();
		Egyptian.Type = "Cat";
		Egyptian.Breed = "Egyptian";
		Egyptian.Name = "Queen";
		Egyptian.Age = 1;
		Egyptian.Nutered = true;

		Animal Pug = new Animal();
		Pug.Type = "Dog";
		Pug.Breed = "Pug";
		Pug.Name = "Snouty";
		Pug.Age = 3;
		Pug.Nutered = false;

		List<Animal> animalList = new List<Animal>() { Mutt, Siamese, Egyptian, Pug };
		foreach(Animal animal in animalList)
		{
			Console.WriteLine(animal.Type);
			Console.WriteLine(animal.Name);
		}
		Console.WriteLine("How old would you like your pet to be?");
		string ageString = Console.ReadLine();
		int age = int.Parse(ageString);

		List<Animal> ageList = new List<Animal>();
		foreach(Animal animal in animalList)
		{
			if(animal.Age < age )
			{
				ageList.Add(animal);
			}
			Console.WriteLine(animal.Name);
		}
		foreach(Animal animal in ageList)
		{	
			Console.WriteLine(animal.Name);
			Console.WriteLine(animal.Type);
			Console.WriteLine(animal.Age);
		}

		Console.WriteLine("Would you like your pet to be nutered? true/false");
		string nuteredQ = Console.ReadLine();
		bool nuteredBool = bool.Parse(nuteredQ);

		if(nuteredBool == true)
		{
			List<Animal> nuteredList = new List<Animal>();
			foreach(Animal animal in animalList)
			{
				if(animal.Nutered == true)
				{
					nuteredList.Add(animal);
				}
			} 
			foreach(Animal animal in nuteredList)
			{
				Console.WriteLine(animal.Type);
				Console.WriteLine(animal.Name);
				Console.WriteLine(animal.Nutered);
			}
		}
		
		Console.WriteLine("Would you like a cat?y/n");
		string wantCat = Console.ReadLine();

		List<Animal> catList = new List<Animal>();
		foreach(Animal animal in animalList)
		{
			if(animal.Type == "Cat")
			{
				catList.Add(animal);
			}
		}

		if(wantCat == "y")
		{
			foreach(Animal animal in catList)
			{
				if(animal.IsCat(animal.Type) == true)
				{
					Console.WriteLine(animal.Type);
					Console.WriteLine(animal.Name);
				}
				else
				{
					Console.WriteLine("OK no cats for you!");
				}
			}	

		}	
		
	}
}	