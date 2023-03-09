using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Linq
{
    public class GroupByTests : TestBase
    {
        public GroupByTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestGroupBy()
        {
            IEnumerable<(string, string)> cars = Enumerable.Range(1, _faker.Random.Int(2, 10))
                .Select(_ => (_faker.Vehicle.Model(), _faker.Vehicle.Type()));

            var groupedCars = cars.GroupBy(c => c.Item1).OrderBy(i => i.Key);

            foreach (var groupedCar in groupedCars)
            {
                groupedCar.Key.Should().NotBeEmpty();
            }
        }
    }
}
