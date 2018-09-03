namespace Calendar 
{
	public class LeapYear
	{
		public bool IsLeapYear(int year)
		{
			if(year % 100 == 0)
			{
				return false;
			}
			else
			{
				return year % 4 == 0;
			}
		}
	}
}