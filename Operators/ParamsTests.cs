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

        [Fact]
        public void TestOutParam()
        {
            OutVariableFromFunction(out int result);

            result.Should().BeGreaterThan(0);
        }

        private void OutVariableFromFunction(out int result)
        {
            result = _faker.Random.Int(min: 1);
        }

        [Fact]
        public void TestRefParam()
        {
            int initialValue = _faker.Random.Int(max: 0);
            int result = initialValue;

            RefVariableInsideFunction(ref result);

            result.Should().NotBe(initialValue);
        }

        private void RefVariableInsideFunction(ref int result)
        {
            result = _faker.Random.Int(min: 1);
        }
    }
}
