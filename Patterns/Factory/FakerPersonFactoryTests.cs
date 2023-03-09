using CSharpStorybook.Models;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Patterns.Factory
{
    public class FakerPersonFactoryTests : TestBase
    {
        public FakerPersonFactoryTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestCreate()
        {
            Person person = new FakerPersonFactory().GetPersons().First();

            person.Should().NotBeNull();
            person.Name.Should().NotBeNullOrEmpty();
        }
    }
}
