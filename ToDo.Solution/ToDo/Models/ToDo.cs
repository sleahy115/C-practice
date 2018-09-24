using System;
using System.Collections.Generic;
using System.Linq;
	
	public class Item
	{
		private string _description;
		private  int _taskNumber;
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

		public void SetTaskNumber(int newTaskNumber)
		{
			_taskNumber = newTaskNumber;
		}

		public int GetTaskNumber()
		{
			return _taskNumber;
		}

		public void Save()
		{
			_instances.Add(this);
		}
	}
	public class Program
	{
		static int taskNumber = 1;
		static void Main()
		{	
			Console.WriteLine("Would you like to create a new list or see an existing one?");
			string newOrExisting = Console.ReadLine();
			if(newOrExisting == "new")
			{
				CreateList();
			}
			else
			{
				ShowList();
			}

		}
		static void CreateList()
		{
			// List<Item> newList = new List<Item> {};
			AddItem();
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
				newItem.SetTaskNumber(taskNumber++);
				newItem.Save();
				AddItem();
			}
			else
			{
				ShowList();

			}
		}
		static void ShowList()
		{
			List<Item> toDoList = Item.GetAll();

			if(toDoList.Count < 1)
			{
				Console.WriteLine("Nothing found in your to do list. Would you like to add items? y/n");
				string emptyListResponse = Console.ReadLine();
				if(emptyListResponse == "y")
				{
					AddItem();
				}
				else
				{
					Console.WriteLine("OK thanks for using the to do list app");
				}
			}
			else
			{
				foreach(var listItem in toDoList)
				{
					string outputTask = listItem.GetDescription().ToString();
					int outputNumber = listItem.GetTaskNumber();
					Console.WriteLine(outputNumber + "  " + outputTask);
				}
			}
		}
		static void CompletedItem()
		{
			// List<Item> toDoList = Item.GetAll();

			Console.WriteLine("Which task would you like to check off?");	
		}

	}