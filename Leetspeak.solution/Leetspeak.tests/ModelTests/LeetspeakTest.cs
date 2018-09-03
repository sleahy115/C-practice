using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;

namespace Leetspeak.Test
{
	[TestClass]
	public class LeetspeakTest
	{
		[TestMethod]
		public void Translate_replaceE_false()
		{
			Leetspeak testPhrase = new Leetspeak();
			Assert.AreEqual("false", testPhrase.Translate("false"));
		}
			
	}
}