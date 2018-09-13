using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using ToDo.Models;

namespace ToDo.Tests
{
	[TestClass]
	public class ItemTest : IDisposable
	{
		public void Dispose()
		{
			Item.ClearAll();
		}

		[TestMethod]
		public void GetDescription_ReturnsDescription_String()
		{			
		//Arrange
		string description = "Walk dog";
		Item newItem = new Item(description);

		//Act
		string result = newItem.GetDescription();

		//Assert
		Assert.AreEqual(description, result);
		}

		[TestMethod]
		public void Save_ItemSavedToInstances_Item()
		{
			//Arrange
			string description = "walk the dog";
			Item newItem = new Item(description);
			newItem.Save();

			//Act
			List<Item> instances = Item.GetAll();
			Item savedItem  = instances[0];


			//Assert	
			Assert.AreEqual(newItem, savedItem);
		}

		[TestMethod]
		public void getAll_ReturnListOfItems_ItemList()
		{
			//Arrange
			string descriptionOne = "walk the dog";
			string descriptionTwo =" wash the dishes";
			Item newItemOne = new Item(descriptionOne);
			Item newItemTwo = new Item(descriptionTwo);
			newItemOne.Save();
			newItemTwo.Save();
			List<Item> itemList = new List<Item> {newItemOne, newItemTwo};

			//Act
			List<Item> result = Item.GetAll();


			// Assert
			CollectionAssert.AreEqual(itemList, result);
		}
	}

}