using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Arrays
{
    public class CreateTests : TestBase
    {
        public CreateTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestCreate()
        {
            int count = 5;
            string[] names = new string[count].Select(_ => _faker.Name.FirstName()).ToArray();

            names.Length.Should().Be(count);
            names.All(name => name != string.Empty).Should().BeTrue();
        }
    }
}
