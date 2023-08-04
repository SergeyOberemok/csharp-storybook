using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Numbers
{
    public class ParseTests : TestBase
    {
        public ParseTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestIntParseString()
        {
            int number = _faker.Random.Number(1, 100);
            string numberStr = number.ToString();

            int result = int.Parse(numberStr);

            result.Should().Be(number);
        }

        [Fact]
        public void TestIntParseEmptyString()
        {
            Action act = () => int.Parse(string.Empty);
            
            act.Should().Throw<FormatException>();
        }

        [Fact]
        public void TestIntParseNull()
        {
            Action act = () => int.Parse(null);

            act.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void TestIntTryParseIntString()
        {
            string numberStr = _faker.Random.Number(1, 100).ToString();

            bool isNumeric = int.TryParse(numberStr, out int number);

            Assert.True(isNumeric);
            number.Should().BeGreaterThan(0).And.BeLessThan(101);
        }

        [Fact]
        public void TestIntTryParseEmptyString()
        {
            string numberStr = string.Empty;

            bool isNumeric = int.TryParse(numberStr, out int number);

            Assert.False(isNumeric);
            number.Should().Be(0);
        }

        [Fact]
        public void TestIntTrypParseNull()
        {
            string numberStr = null;

            bool isNumeric = int.TryParse(numberStr, out int number);

            Assert.False(isNumeric);
            number.Should().Be(0);
        }

        [Fact]
        public void TestDecimalTryParseIntString()
        {
            string numberStr = _faker.Random.Number(1, 100).ToString();

            bool isNumeric = decimal.TryParse(numberStr,out decimal number);

            Assert.True(isNumeric);
            number.Should().BeGreaterThan(0).And.BeLessThan(101);
        }
    }
}
