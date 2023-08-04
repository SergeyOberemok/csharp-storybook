using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Dates
{
    public class DateTests : TestBase
    {
        public DateTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestDateOverdue()
        {
            DateTime dueDate = _faker.Date.Recent(15);

            int overdueCount = dueDate.Subtract(DateTime.Now).Days;

            overdueCount.Should().BeLessThan(0);
        }

        [Fact]
        public void TestDateDoesntOverdue()
        {
            DateTime dueDate = _faker.Date.Soon(15, DateTime.Now);

            int overdueCount = dueDate.Subtract(DateTime.Now).Days;

            overdueCount.Should().BeGreaterThan(0);
        }

        [Fact]
        public void TestDateAddDays()
        {
            DateTime tomorrow = DateTime.Now.AddDays(1);

            bool result = tomorrow > DateTime.Now;

            result.Should().BeTrue();
        }

        [Fact]
        public void TestDateSubtractDays()
        {
            DateTime yesterday = DateTime.Now.AddDays(-1);

            bool result = yesterday < DateTime.Now;

            result.Should().BeTrue();
        }
    }
}
