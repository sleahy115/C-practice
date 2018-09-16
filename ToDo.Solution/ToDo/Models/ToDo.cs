using System;
using System.Collections.Generic;
	
	public class Item
	{
		private string _description;
		private static List<Item> _instances = new List<Item> {};

		//static methods
		public static void ClearAll()
		{
			_instances.Clear();
		}

		public static List<Item> GetAll()
		{
			return _instances;
		} 

		//instance methods
		public Item (string description)
		{
			_description = description;
		}

		public string GetDescription()
		{
			return _description;
		}

		public void SetDescription(string newDescription)
		{
			_description = newDescription;
		}

		public void Save()
		{
			_instances.Add(this);
		}
	}
	public class Program
	{
		static void Main()
		{
			Console.WriteLine("Would you like to see your to do list? y/n");
			string showList = Console.ReadLine();

			if(showList == "y")
			{
				Console.WriteLine("Here is your list ");	
			}
			else
			{
				Console.WriteLine("Thanks for checking the list");
			}
		}

		static void AddItem()
		{
			Console.WriteLine("Would you like to add an item to your to do list? y/n");
			string addItemResponse = Console.ReadLine();

			if(addItemResponse == "y")
			{	
				Console.WriteLine("Please enter the description");
				string newItemDesc = Console.ReadLine();
				Item newItem = new Item(newItemDesc);
				newItem.SetDescription(newItemDesc);
				newItem.Save();
			}

		}

	}