using NUnit.Framework;
using KatasCSharp.DetectPangram;

namespace KatasCSharp.Tests
{
    public class DetectPangramTest
    {
        [TestCase("This isn't a pangram!", false)]
        [TestCase("Cwm fjord bank glyphs vext quiz", true)]
        public void Test(string s, bool expectedResult)
        {
            Assert.AreEqual(expectedResult, DetectPangramKata.IsPangram(s));
        }
    }
}
