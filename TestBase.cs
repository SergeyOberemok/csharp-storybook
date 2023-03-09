using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

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

        protected IEnumerable<int> GenerateRandomNumbers(int size, int max)
        {
            return Enumerable.Range(1, size).Select(i => _faker.PickRandom(Enumerable.Range(1, max))).ToList();
        }
    }
}
