using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Operators
{
    public class ParamsTests : TestBase
    {
        public ParamsTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestArrayParams()
        {
            var numbers = Enumerable.Range(1, 10).ToArray();

            int result = SumNumbers(numbers);

            result.Should().Be(55);
        }

        [Fact]
        public void TestCommaSeparatedParams()
        {
            int result = SumNumbers(1, 2, 3);

            result.Should().Be(6);
        }

        private int SumNumbers(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
