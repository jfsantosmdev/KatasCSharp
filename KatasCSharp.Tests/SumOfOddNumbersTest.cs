using NUnit.Framework;
using KatasCSharp.SumOfOddNumbers;
using System;

namespace KatasCSharp.Tests
{
    public class SumOfOddNumbersTest
    {
        [Test]
        public void Test()
        {
            Random rnd = new Random();
            for (long i = 0; i < 50; i++)
            {
                long n = rnd.Next(1, 100);
                Assert.AreEqual(n * n * n, SumOfOddNumbersKata.rowSumOddNumbers(n));
            }
        }
    }
}
