using NUnit.Framework;

namespace Kata.Tests
{
    [TestFixture]
    public class ProductExceptSelfTests
    {
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
        [TestCase(new int[] { 1, 2, 0, 3, 3 }, new int[] { 0, 0, 18, 0, 0 })]
        public void Test(int[] input, int[] expected)
        {
            Assert.AreEqual(expected, new ProductExceptSelf().Compute(input));
        }
    }
}
