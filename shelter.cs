using System;
using System.Collections. Generic;

public class Animal
{
	public string Type;
	public string Breed;
	public string Name;
	public int Age;
	public bool Nutered;
}

class Program
{
	public void static Main()
	{
		Animal Mutt = new Animal();
		Mutt.Type = "Dog";
		Mutt.Breed = "Mutt";
		Mutt.Name = "Rusty";
		Mutt.Age = 5;
		Mutt.Nutered = Y;

		Animal Siamese = new Animal();
		Siamese.Type = "Cat";
		Siamese.Breed = "Siamese";
		Siamese.Name = "King";
		Siamese.Age = 2;
		Siamese.Nutered = N;

		Animal Egyptian = new Animal();
		Egyptian.Type = "Cat";
		Egyptian.Breed = "Egyptian";
		Egyptian.Name = "Queen";
		Egyptian.Age = 1;
		Egyptian.Nutered = N;

		Animal Pug = new Animal();
		Pug.Type = "Dog";
		Pug.Breed = "Pug";
		Pug.Name = "Snouty";
		Pug.Age = 3;
		Pug.Nutered = Y;

		List<Animal> = animalList = new List<Animal>(); { Mutt, Siamese, Egyptian, Pug };
		foreach(Animal animal in animalList)
		{
			Console.WriteLine(animal.type);
		}

	}
}	