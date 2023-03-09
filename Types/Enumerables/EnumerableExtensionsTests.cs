using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Enumerables
{
    public class EnumerableExtensionsTests : TestBase
    {
        public EnumerableExtensionsTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestIterateWithIndex()
        {
            var words = _faker.Lorem.Words();
            int counter = 0;

            foreach (var (word, index) in words.WithIndex())
            {
                word.Should().NotBeEmpty();
                words.Contains(word).Should().BeTrue();
                index.Should().Be(counter);

                counter++;
            }
        }
    }
}
