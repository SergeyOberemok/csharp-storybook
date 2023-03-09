using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpStorybook.Types
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
