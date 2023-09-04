using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Dictionary
{
    public class ReadTests : TestBase
    {
        public ReadTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestGet()
        {
            IDictionary<string, int> dictionary = GenerateNameAgeDictionary();
            IEnumerable<string> names = dictionary.Keys;

            int age = dictionary[names.First()];

            age.Should().BeGreaterThan(0);
        }
    }
}
