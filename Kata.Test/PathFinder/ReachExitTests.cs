using FluentAssertions;
using Kata.PathFinder;
using Xunit;

namespace Kata.Test.PathFinder
{
    public class ReachExitTests
    {

        [Theory]
        [InlineData(".W..W....", true)]
        [InlineData(".W..W.W..", false)]
        [InlineData("....................................", true)]
        [InlineData(".............................W....W.", false)]
        public void Test(string maze, bool expected)
        {
            ReachExit.Find(maze).Should().Be(expected);
        }
    }
}
