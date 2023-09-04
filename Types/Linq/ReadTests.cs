using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Linq
{
    public class ReadTests : TestBase
    {
        public ReadTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestAll()
        {
            var numbers = new int[5].Select(_ => _faker.Random.Number(1, 10));

            numbers.All(n => n > 0).Should().BeTrue();
        }

        [Fact]
        public void TestContains()
        {
            string[] words = _faker.Lorem.Words();
            string word = words.First();

            words.Contains(word).Should().BeTrue();
        }
    }
}
