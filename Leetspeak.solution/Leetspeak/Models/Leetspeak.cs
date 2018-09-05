using System;

namespace Leetspeak
{
	public class Leetspeak
	{
		public string Translate(string phrase)
		{	
			if(phrase.Contains("I"))
			{
				phrase = phrase;
			}
			else
			{
				phrase = phrase.ToLower();
			}
			char[] array = phrase.ToCharArray();

			for(int i = 0; i < array.Length; i++)
			{
				if(array[i] == 'e')
				{
					array[i] = '3';
				}
				if(array[i] == 'o')
				{
					array[i] = '0';
				}
				if(array[i] == 'I')
				{
					array[i] = '1';
				}
			}
			string stringReturn = string.Join("", array);
			return stringReturn;
		}
	}
}