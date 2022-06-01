using NUnit.Framework;
using KatasCSharp.StopSpinningMyWords;
namespace KatasCSharp.Tests
{
    public class StopSpinningMyWordsTest
    {
        [TestCase("Welcome", "emocleW")]
        [TestCase("Hey fellow warriors", "Hey wollef sroirraw")]
        [TestCase("This sentence is a sentence", "This ecnetnes is a ecnetnes")]
        public void Test(string s, string expectedResult)
        {
            Assert.AreEqual(expectedResult, StopSpinningMyWordsKata.SpingWords(s));
        }
    }
}
