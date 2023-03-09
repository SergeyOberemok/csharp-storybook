using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Strings
{
    public class FormatTests : TestBase
    {
        public FormatTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestToStringWithFormat()
        {
            string format = "x4";
            int aNumber = 0x22;
            char aChar = 'a';

            aNumber.ToString(format).Should().Be("0022");
            ((int)aChar).ToString(format).Should().Be("0061");
        }
    }
}
