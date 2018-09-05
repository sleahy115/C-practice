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
		// [TestMethod]
		// public void Translate_replaceE_3()
		// {
		// 	Leetspeak testE = new Leetspeak();
		// 	Assert.AreEqual("h3llo", testE.Translate("hello"));
		// }

		// [TestMethod]
		// public void Translate_replaceE_capitol_3()
		// {
		// 	Leetspeak testECapitol = new Leetspeak();
		// 	Assert.AreEqual("h3llo", testECapitol.Translate("HELLO"));
		// }

		// [TestMethod]
		// public void Translate_replaceO_0()
		// {
		// 	Leetspeak testO = new Leetspeak();
		// 	Assert.AreEqual("h3ll0", testO.Translate("HELLO"));
		// }

		[TestMethod]
		public void Translate_replaceI_1()
		{
			Leetspeak testI = new Leetspeak();
			Assert.AreEqual("H3ll0 1n th3r3", testI.Translate("Hello In there"));
		}
			
	}
		
}