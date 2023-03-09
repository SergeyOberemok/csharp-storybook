using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Strings
{
    public class CompareTests : TestBase
    {
        public CompareTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestCompareIgnoringCase()
        {
            string word = _faker.Lorem.Word();

            bool result = String.Equals(word, word.ToUpper(), StringComparison.OrdinalIgnoreCase);

            result.Should().BeTrue();
        }
    }
}
