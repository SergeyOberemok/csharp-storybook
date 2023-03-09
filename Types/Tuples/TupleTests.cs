using FluentAssertions;
using Xunit;

namespace CSharpStorybook.Types.Tuples
{
    public class TupleTests
    {
        [Fact]
        public void TestTupleGettingValues()
        {
            var numbers = Tuple.Create(2, 4, 6);

            numbers.Item1.Should().Be(2);
            numbers.Item2.Should().Be(4);
            numbers.Item3.Should().Be(6);
        }

        [Fact]
        public void TestValueTupleGettingValues()
        {
            var numbers = (one: 2, two: 4, three: 6);

            numbers.one.Should().Be(2);
            numbers.two.Should().Be(4);
            numbers.three.Should().Be(6);
        }

        [Fact]
        public void TestValueTupleGettingUnnamedValues()
        {
            var numbers = (2, 4, 6);

            numbers.Item1.Should().Be(2);
            numbers.Item2.Should().Be(4);
            numbers.Item3.Should().Be(6);
        }
    }
}
