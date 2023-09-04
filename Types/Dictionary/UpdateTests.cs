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
    public class UpdateTests : TestBase
    {
        public UpdateTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestUpdateValue()
        {
            int newAge = 2000;
            IDictionary<string, int> dictionary = GenerateNameAgeDictionary();
            string name = dictionary.Keys.First();

            dictionary[name] = newAge;

            dictionary.Contains(KeyValuePair.Create(name, newAge)).Should().BeTrue();
        }

        [Fact]
        public void JoinEntriesTest()
        {
            IDictionary<string, int> nameAgeDictionary = GenerateNameAgeDictionary();

            string joined = string.Join("; ", nameAgeDictionary.Select(nameAge => $"{nameAge.Key} {nameAge.Value}"));

            nameAgeDictionary.Select(nameAge => joined.Contains(nameAge.Key) && joined.Contains(nameAge.Value.ToString())).All(flag => flag).Should().BeTrue();
        }
    }
}
