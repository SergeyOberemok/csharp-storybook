using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Linq
{
    public class ContainsTests : TestBase
    {
        public ContainsTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestContainsInArray() 
        {
            string[] words = _faker.Lorem.Words();
            string word = words.First();

            words.Contains(word).Should().BeTrue();
        }
    }
}
