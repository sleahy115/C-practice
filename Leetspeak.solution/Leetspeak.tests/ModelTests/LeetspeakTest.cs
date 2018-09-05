using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;

namespace Leetspeak.Test
{
	[TestClass]
	public class LeetspeakTest
	{
		// [TestMethod]
		// public void Translate_replaceE_false()
		// {
		// 	Leetspeak testPhrase = new Leetspeak();
		// 	Assert.AreEqual("false", testPhrase.Translate("false"));
		// }

		// [TestMethod]
		// public void Translate_SplitPhraseIntoArray()
		// {
		// 	Leetspeak testSplit = new Leetspeak();
		// 	Assert.AreEqual("hello", testSplit.Translate("hello"));
		// }
		[TestMethod]
		public void Translate_replaceE_true()
		{
			Leetspeak testE = new Leetspeak();
			Assert.AreEqual("h3llo", testE.Translate("hello"));
		}
			
	}
}