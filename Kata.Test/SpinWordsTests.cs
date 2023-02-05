using FluentAssertions;
using Xunit;

namespace Kata.Test
{
    public class SpinWordsTests
    {
        [Fact]
        public static void Test()
        {
            SpinWords.Spin("Welcome").Should().Be("emocleW");
            SpinWords.Spin("Hey fellow warriors").Should().Be("Hey wollef sroirraw");
            SpinWords.Spin("This is a test").Should().Be("This is a test");
            SpinWords.Spin("This is another test").Should().Be("This is rehtona test");
            SpinWords.Spin("You are almost to the last test").Should().Be("You are tsomla to the last test");
            SpinWords.Spin("Just kidding there is still one more").Should().Be("Just gniddik ereht is llits one more");
        }
    }
}
