using FluentAssertions;
using Xunit;

namespace CSharpStorybook.Types.Enumerables
{
    public class EnumerablesTests
    {
        [Fact]
        public void TestRange()
        {
            int size = 10;
            int[] range = Enumerable.Range(0, 10).ToArray();

            for (int i = 0; i < size; i++)
            {
                int number = range[i];

                number.Should().Be(i);
            }
        }
    }
}
