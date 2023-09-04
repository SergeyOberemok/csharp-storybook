using Bogus;
using System.Collections.Generic;
using Xunit.Abstractions;
using System.Linq;

namespace CSharpStorybook
{
    public class TestBase
    {
        protected Bogus.Faker _faker = new Bogus.Faker();
        protected readonly ITestOutputHelper _output;

        public TestBase(ITestOutputHelper output)
        {
            _output = output;
        }

        protected IEnumerable<int> GenerateRandomNumbers(int size = 1, int max = 100)
            => Enumerable.Range(1, size)
                .Select(_ => _faker.PickRandom(Enumerable.Range(1, max)))
                .ToList();

        protected IEnumerable<(string, string)> GenerateCars(int size = 1)
            => Enumerable.Range(1, size)
                .Select(_ => (_faker.Vehicle.Model(), _faker.Vehicle.Type()));

        protected IDictionary<string, int> GenerateNameAgeDictionary(int size = 1)
            => Enumerable.Range(1, size)
                .Select(_ => (_faker.Name.FirstName(), _faker.Random.Int(1, 100)))
                .Aggregate(new Dictionary<string, int>(), (acc, nameAndAge) =>
                {
                    acc.Add(nameAndAge.Item1, nameAndAge.Item2);
                    return acc;
                });
    }
}
