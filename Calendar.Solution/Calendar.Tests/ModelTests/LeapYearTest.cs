using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace Calendar.Test
{
	[TestClass]
	public class LeapYearTest
	{
		[TestMethod]
		public void IsLeapYear_NumberDivisibleByFour_True()
		{
			LeapYear testLeapYear = new LeapYear();
			Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));

		}
	}
}