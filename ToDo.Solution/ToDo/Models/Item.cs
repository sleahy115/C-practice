using System.Collections.Generic;

namespace ToDo.Models
{
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

}