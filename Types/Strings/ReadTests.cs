using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Strings
{
    public class ReadTests : TestBase
    {
        public ReadTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestCompareIgnoringCase()
        {
            string word = _faker.Lorem.Word();

            bool result = string.Equals(word, word.ToUpper(), StringComparison.OrdinalIgnoreCase);

            result.Should().BeTrue();
        }

        [Fact]
        public void TestInclude()
        {
            string word = _faker.Lorem.Word();
            string sentence = string.Join(word, _faker.Lorem.Words(2));

            bool result = sentence.Contains(word);

            result.Should().BeTrue();

            result = sentence.Contains(word.ToUpper());

            result.Should().BeFalse();
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
