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

		// [TestMethod]
		// public void Translate_replaceI_1()
		// {
		// 	Leetspeak testI = new Leetspeak();
		// 	Assert.AreEqual("H3ll0 1n th3r3", testI.Translate("Hello In there"));
		// }
		
		// [TestMethod]
		// public void Translate_replaceT_7()
		// {
		// 	Leetspeak testT = new Leetspeak();
		// 	Assert.AreEqual("h3ll0 in 7h3r3", testT.Translate("Hello in there"));
		// }
		[TestMethod]
		public void Translate_replaceS_z()
		{
			Leetspeak testS = new Leetspeak();
			Assert.AreEqual("h3ll0 in 7h3r3 m3lizza", testS.Translate("Hello in there Melissa"));
		}
		[TestMethod]
		public void Translate_replaceS_s()
		{
			Leetspeak testS = new Leetspeak();
			Assert.AreEqual("H3ll0 in 7h3r3 Sally", testS.Translate("Hello in there Sally"));
		}
		// [TestMethod]
		// public void English_replace3_e()
		// {
		// 	Leetspeak test3 = new Leetspeak();
		// 	Assert.AreEqual("Hello", test3.English("H3ll0"));
		// }
		[TestMethod]
		public void English_replace0_o()
		{
			Leetspeak test0 = new Leetspeak();
			Assert.AreEqual("Hello", test0.English("H3ll0"));
		}
		[TestMethod]
		public void English_replace1_I()
		{
			Leetspeak test0 = new Leetspeak();
			Assert.AreEqual("Hello In There", test0.English("H3ll0 1n Th3r3"));
		}
		[TestMethod]
		public void English_replace7_t()
		{
			Leetspeak test7 = new Leetspeak();
			Assert.AreEqual("Hello in there", test7.English("H3ll0 in 7h3r3"));
		}
		[TestMethod]
		public void English_replacez_s()
		{
			Leetspeak testZ = new Leetspeak();
			Assert.AreEqual("Hello in there Melissa", testZ.English("H3ll0 in 7h3r3 M3lissa"));
		}
	}
		
}