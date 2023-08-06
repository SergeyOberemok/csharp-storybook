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
    public class CheckTests : TestBase
    {
        public CheckTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestAll()
        {
            var numbers = new int[5].Select(_ => _faker.Random.Number(1, 10));

            numbers.All(n => n > 0).Should().BeTrue();
        }
    }
}
