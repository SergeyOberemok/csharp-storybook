using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Dictionary
{
    public class CreateTests : TestBase
    {
        public CreateTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void ToDictionaryDuplicateItemsTest()
        {
            var words = _faker.Random.WordsArray(3, 5)
                .Select((word, i) => KeyValuePair.Create(i, word))
                .ToList();

            words.Add(words[0]);

            // Should throw an exception that 0 already exists
            Action act = () => words.ToDictionary(x => x.Key, x => x.Value);

            act.Should().Throw<ArgumentException>();
        }
    }
}
