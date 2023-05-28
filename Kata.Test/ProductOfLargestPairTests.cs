using FluentAssertions;
using Xunit;

namespace Kata.Test
{
    public class ProductOfLargestPairTests
    {
        [Fact]
        public void Test()
        {
            ProductOfLargestPair.MaxProduct(new int[] { 56, 335, 195, 443, 6, 494, 252 }).Should().Be(218842);
            ProductOfLargestPair.MaxProduct(new int[] { 154, 428, 455, 346 }).Should().Be(194740);
            ProductOfLargestPair.MaxProduct(new int[] { 39, 135, 47, 275, 37, 108, 265, 457, 2, 133, 316, 330, 153, 253, 321, 411 }).Should().Be(187827);
            ProductOfLargestPair.MaxProduct(new int[] { 136, 376, 10, 146, 105, 63, 234 }).Should().Be(87984);
            ProductOfLargestPair.MaxProduct(new int[] { 354, 463, 165, 62, 472, 53, 347, 293, 252, 378, 420, 398, 255, 89 }).Should().Be(218536);
            ProductOfLargestPair.MaxProduct(new int[] { 346, 446, 26, 425, 432, 349, 123, 269, 285, 93, 75, 14 }).Should().Be(192672);
            ProductOfLargestPair.MaxProduct(new int[] { 134, 320, 266, 299 }).Should().Be(95680);
            ProductOfLargestPair.MaxProduct(new int[] { 114, 424, 53, 272, 128, 215, 25, 329, 272, 313, 100, 24, 252 }).Should().Be(139496);
            ProductOfLargestPair.MaxProduct(new int[] { 375, 56, 337, 466, 203 }).Should().Be(174750);
        }
    }
}
