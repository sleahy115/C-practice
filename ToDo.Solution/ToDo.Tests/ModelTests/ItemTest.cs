using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDo.Models;

namespace ToDo.Tests
{
	[TestClass]
	public class ItemTest
	{
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
	}
}