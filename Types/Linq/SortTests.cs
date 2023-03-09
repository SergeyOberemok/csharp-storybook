using Bogus;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Linq
{
    public class SortTests : TestBase
    {
        public SortTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestSort()
        {
            int size = 10;
            int max = 10;
            IEnumerable<int> randomNumbers = GenerateRandomNumbers(size, max);

            IEnumerable<int> sortedRandomNumbers = randomNumbers.OrderBy(i => i).ToList();

            randomNumbers.Should().NotEqual(sortedRandomNumbers);
            randomNumbers.Should().BeEquivalentTo(sortedRandomNumbers);
        }
    }
}
