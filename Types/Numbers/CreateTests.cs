using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Numbers
{
    public class CreateTests : TestBase
    {
        public CreateTests(ITestOutputHelper output) : base(output)
        {
        }

        #region Int

        [Fact]
        public void TestIntParseString()
        {
            int number = _faker.Random.Number(1, 100);

            int result = int.Parse(number.ToString());

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
            bool isNumeric = int.TryParse(string.Empty, out int number);

            Assert.False(isNumeric);
            number.Should().Be(0);
        }

        [Fact]
        public void TestIntTryParseNull()
        {
            string numberStr = null;

            bool isNumeric = int.TryParse(numberStr, out int number);

            Assert.False(isNumeric);
            number.Should().Be(0);
        }

        #endregion Int

        #region Decimal

        [Fact]
        public void TestDecimalTryParseIntString()
        {
            string numberStr = _faker.Random.Number(1, 100).ToString();

            bool isNumeric = decimal.TryParse(numberStr,out decimal number);

            Assert.True(isNumeric);
            number.Should().BeGreaterThan(0).And.BeLessThan(101);
        }

        #endregion Decimal

        #region Long

        [Fact]
        public void TestLongTryParseLongString()
        {
            int number = _faker.Random.Number();

            bool isNumeric = long.TryParse(number.ToString(), out long result);

            Assert.True(isNumeric);
            number.Should().Be(number);
        }

        [Fact]
        public void TestLongTryParseEmptyString()
        {
            bool isNumeric = int.TryParse(string.Empty, out int number);

            Assert.False(isNumeric);
            number.Should().Be(0);
        }

        #endregion Long
    }
}
