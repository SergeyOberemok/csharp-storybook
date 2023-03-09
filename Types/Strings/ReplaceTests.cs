using FluentAssertions;
using System.Text.RegularExpressions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Strings
{
    public class ReplaceTests : TestBase
    {
        public ReplaceTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestReplace()
        {
            string sentence = _faker.Lorem.Sentence();

            string result = Regex.Replace(sentence, @"[\s\.]+", "");

            result.Contains(' ').Should().BeFalse();
        }
    }
}
