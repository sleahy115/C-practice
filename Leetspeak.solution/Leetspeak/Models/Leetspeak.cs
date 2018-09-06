using System;

	private class Leetspeak
	{
		private string _phrase;
		private string _stringReturn;

		public void SetPhrase(string newPhrase)
		{
			_phrase = newPhrase;
		}

		public string GetPhrase()
		{
			return _phrase;
		}

		public void SetstringReturn(string newStringReturn)
		{
			_stringReturn = newStringReturn;
		}

		public string GetStringReturn()
		{
			return _stringReturn;
		}

		static void Main()
		{
			Console.WriteLine("Enter a phrase to have it translated to Leetspeak");
			phrase = Console.ReadLine();
			Translate(phrase);
		}

		public string Translate(string phrase)
		{	

			if(phrase.Contains("I") || phrase.Contains("S"))
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

		public string English(string englishPhrase)
		{
			char[] englishArray = englishPhrase.ToCharArray();

			for(int i = 0; i < englishArray.Length; i++)
			{
				if(englishArray[i] == '3')
				{
					englishArray[i] = 'e';
				}
				if(englishArray[i] == '0')
				{
					englishArray[i] = 'o';
				}
				if(englishArray[i] == '1')
				{
					englishArray[i] = 'I';
				}
				if(englishArray[i] == '7')
				{
					englishArray[i] = 't';
				}
				if(englishArray[i] == 'z')
				{
					englishArray[i] = 's';
				}
			}
			string englishReturn = string.Join("", englishArray);
			return englishReturn;
		}
	}