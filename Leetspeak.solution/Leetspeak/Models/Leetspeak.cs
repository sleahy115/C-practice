using System;

namespace Leetspeak
{
	public class Leetspeak
	{
		public string Translate(string phrase)
		{	
			// public bool begins = false;

			if(phrase.Contains("I") || phrase.Contains("S"))
			{
				phrase = phrase;
			}
			// else if(phrase.StartsWith("S") == true)
			// {
			// 	begins = true;
			// }
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
				if(array[i] == 't')
				{
					array[i] = '7';
				}
				if(array[i] == 'S' && phrase.StartsWith("S") == true)
				{
					array[i] = 'S';
				}
				if(array[i] == 's')
				{
					array[i] = 'z';
				}
			}
			string stringReturn = string.Join("", array);
			return stringReturn;
		}
	}
}