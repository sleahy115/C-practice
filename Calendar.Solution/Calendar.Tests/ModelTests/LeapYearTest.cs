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
		[TestMethod]
		public void IsLeapYear_NumberDivisibleByFour_False()
		{
			LeapYear testFalseYear = new LeapYear();
			Assert.AreEqual(false, testFalseYear.IsLeapYear(1999));
		}
		[TestMethod]
		public void IsLeapYear_MultiplesOfOneHundred_True()
		{
			LeapYear testFalseHundred = new LeapYear();
			Assert.AreEqual(false, testFalseHundred.IsLeapYear(1900));
		}
		[TestMethod]
		public void IsLeapYear_MultiplesOfFourHundred_True()
		{
			LeapYear testTrueFourHundred = new LeapYear();
			Assert.AreEqual(true, testTrueFourHundred.IsLeapYear(2000));
		}
	}
}