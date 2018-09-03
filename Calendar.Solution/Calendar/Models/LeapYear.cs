namespace Calendar 
{
	public class LeapYear
	{
		public bool IsLeapYear(int year)
		{
			return year % 4 == 0;
		}
	}
}