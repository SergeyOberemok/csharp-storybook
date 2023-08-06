using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Numbers
{
    public class ComparisonTests : TestBase
    {
        public ComparisonTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestInt64MinValue()
        {
            Int64.MinValue.Should().Be(long.MinValue);

            _output.WriteLine(Int64.MinValue.ToString());
        }

        [Fact]
        public void TestInt64MaxValue()
        {
            Int64.MaxValue.Should().Be(long.MaxValue);
            _output.WriteLine(Int64.MaxValue.ToString());
        }

        [Fact]
        public void TestDoubleMaxValue()
        {
            double.MaxValue.Should().BeGreaterThan(long.MaxValue);
        }

        [Fact]
        public void TestDoubleMinValue()
        {
            double.MinValue.Should().BeLessThan(long.MinValue);
        }
    }
}
