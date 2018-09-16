using Microsoft.VisualStudio.TestTools.UnitTesting;
using shapes.Models;

namespace Shapes.TestTools
{
	[TestClass]
	public class CubeTests
	{
		[TestMethod]
		public void Cube_GetVolume_VoulmeOfCube()
		{
			//Arrange
			Rectangle newRectangle = new Rectangle(4,4);
			Cube newCube = new Cube(newRectangle);

			//Act
			int result = newCube.GetVolume();

			//Assert
			Assert.AreEqual(result, 64);
		}
	}
}