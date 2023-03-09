using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Collections
{
    public class HashSetTests : TestBase
    {
        public HashSetTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void ToHashSetDuplicateItemsTest()
        {
            List<KeyValuePair<int, string>> words = _faker.Random.WordsArray(3, 5)
                .Select((word, i) => KeyValuePair.Create(i, word))
                .ToList();
            int initialCount = words.Count();

            words.Add(words[0]);

            HashSet<int> hashSet = null;
            Action act = () => hashSet = words.Select(x => x.Key).ToHashSet();

            act.Should().NotThrow();
            hashSet.Count().Should().Be(initialCount);
            hashSet.Count().Should().NotBe(words.Count());
        }
    }
}
