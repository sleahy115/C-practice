using System;

namespace Leetspeak
{
	public class Leetspeak
	{
		public string Translate(string phrase)
		{
			phrase = phrase.ToLower();
			char[] array = phrase.ToCharArray();

			for(int i = 0; i < array.Length; i++)
			{
				if(array[i] == 'e')
				{
					array[i] = '3';
				}
			}
			string stringReturn = string.Join("", array);
			return stringReturn;
		}
	}
}