using Bogus;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Linq
{
    public class UpdateTests : TestBase
    {
        public UpdateTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestReduce()
        {
            var numbers = GenerateRandomNumbers(10, 10);

            int result = numbers.Aggregate(0, (acc, number) => acc + number);

            result.Should().BeGreaterThan(0);
        }

        [Fact]
        public void TestGroupBy()
        {
            IEnumerable<(string, string)> cars = GenerateCars(5);

            var groupedCars = cars.GroupBy(c => c.Item1).OrderBy(i => i.Key);

            groupedCars.Select(car => car.Key.Should().NotBeEmpty());
        }

        [Fact]
        public void TestSelectManyAllValuesList()
        {
            Tuple<string, string[]>[] people = new[] { new Person(), new Person(), new Person() }
            .Select((person) => Tuple.Create(person.FirstName, new[] { person.Email, person.Phone })).ToArray();

            string[] resultAllPersonsData = people.SelectMany(items => items.Item2).ToArray();

            resultAllPersonsData.Count().Should().BeGreaterThan(people.Count());

            foreach (var (name, data) in people)
            {
                resultAllPersonsData.Contains(name).Should().BeFalse();
                resultAllPersonsData.Contains(data[0]).Should().BeTrue();
                resultAllPersonsData.Contains(data[1]).Should().BeTrue();
            }
        }

        [Fact]
        public void TestSelectManyKeyValueDictionary()
        {
            Tuple<string, string[]>[] people = new[] { new Person(), new Person(), new Person() }
            .Select((person) => Tuple.Create(person.FirstName, new[] { person.Email, person.Phone })).ToArray();

            IList<(string, string)> resultNameAndData = people.SelectMany(items => items.Item2,
                (items, itemFromItem2) => (items.Item1, itemFromItem2)
                ).ToList();

            resultNameAndData.Count().Should().BeGreaterThan(people.Count());

            foreach (var (name, data) in people)
            {
                resultNameAndData.Any(items => items.Item1 == name).Should().BeTrue();
                resultNameAndData.Any(items => data.Contains(items.Item2)).Should().BeTrue();
            }
        }

        [Fact]
        public void TestSort()
        {
            int size = 10;
            int max = 10;
            IEnumerable<int> randomNumbers = GenerateRandomNumbers(size, max);

            IEnumerable<int> sortedRandomNumbers = randomNumbers.OrderBy(i => i).ToList();

            randomNumbers.Should().NotEqual(sortedRandomNumbers);
            randomNumbers.Should().BeEquivalentTo(sortedRandomNumbers);
        }
    }
}
