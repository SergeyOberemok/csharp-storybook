using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Objects.ValueObject
{
    public class EmailTests : TestBase
    {
        public EmailTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestValueObjectEquality()
        {
            string emailBase = _faker.Internet.Email();
            Email emailValueObject = Email.Create(emailBase);

            Assert.True(emailValueObject == emailBase);
        }

        [Fact]
        public void TestValueObjectCast()
        {
            Email email = (Email)_faker.Internet.Email();

            typeof(Email).IsInstanceOfType(email).Should().BeTrue();
        }
    }
}
