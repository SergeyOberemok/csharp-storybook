using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Flow
{
    public class YieldReturnTests : TestBase
    {
        public YieldReturnTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestYieldReturn()
        {
            int length = 10;

            var result = GenerateRandomNumbers(length);

            result.Count().Should().Be(length);
        }

        private new IEnumerable<int> GenerateRandomNumbers(int length, int max = 100)
        {
            while (length > 0)
            {
                yield return _faker.Random.Int(0, max);
                length--;
            }
        }
    }
}
