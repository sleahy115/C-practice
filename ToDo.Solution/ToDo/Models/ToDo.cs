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
				// Console.WriteLine(_description);
				// if(_instances.count == 0)
				// {
				// 	Console.WriteLine("Looks like your list is empty, way to Go. WOuld you like to add to your list?");
				// }
			}
			else
			{
				Console.WriteLine("Thanks for checking the list");
			}
		}
	}