using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Strings
{
    public class StringExtensionTests : TestBase
    {
        public StringExtensionTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestNumberStringExtension()
        {
            string numberStr = _faker.Random.Number(1, 100).ToString();
            string nullStr = null;

            numberStr.IsNumber().Should().BeTrue();
            nullStr.IsNumber().Should().BeFalse();
        }
    }
}
