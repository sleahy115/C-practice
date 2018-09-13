using System.Collections.Generic;

namespace ToDo.Models
{
	public class Item
	{
		private string _description;
		private List<Item> _instances = new List<Item> {};

		public Item (string description)
		{
			_description = description;
		}

		public string GetDescription()
		{
			return _description;
		}

		public void SetDescription(newDescription)
		{
			_description = newDescription;
		}

		public static List<Item> GetAll()
		{
			return _instances;
		} 
		public void Save()
		{
			//_instances.Add(this);
		}
	}
}