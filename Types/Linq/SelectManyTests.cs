using Bogus;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Linq
{
    public class SelectManyTests : TestBase
    {
        public SelectManyTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestSelectManyAllValuesList()
        {
            Tuple<string, string[]>[] people = new[] { new Person(), new Person(), new Person() }
            .Select((Person person) => Tuple.Create(person.FirstName, new[] { person.Email, person.Phone })).ToArray();

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
            .Select((Person person) => Tuple.Create(person.FirstName, new[] { person.Email, person.Phone })).ToArray();

            IList<(string, string)> resultNameAndData = people.SelectMany(items => items.Item2,
                (Tuple<string, string[]> items, string itemFromItem2) => (items.Item1, itemFromItem2)
                ).ToList();

            resultNameAndData.Count().Should().BeGreaterThan(people.Count());

            foreach (var (name, data) in people)
            {
                resultNameAndData.Any(items => items.Item1 == name).Should().BeTrue();
                resultNameAndData.Any(items => data.Contains(items.Item2)).Should().BeTrue();
            }
        }
    }
}

