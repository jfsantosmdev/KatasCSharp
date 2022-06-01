
using KatasCSharp.FizzBuzz;
using NUnit.Framework;
namespace KatasCSharp.Tests
{
    public class FizzBuzzKataFixture
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "Fizz Buzz")]
        public void Test(int i, string expectedResult)
        {
            Assert.AreEqual(expectedResult, FizzBuzzKata.Answer(i));
        }
    }
}