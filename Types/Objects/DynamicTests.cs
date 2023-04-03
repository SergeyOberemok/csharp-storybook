using System.Dynamic;
using Xunit;
using Xunit.Abstractions;

namespace CSharpStorybook.Types.Objects
{
    public class DynamicTests : TestBase
    {
        public DynamicTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestDynamicCreation()
        {
            string sentence = _faker.Lorem.Sentence();
            dynamic expandoObj = new ExpandoObject();

            expandoObj.description = sentence;

            Assert.Equal(sentence, expandoObj.description);
        }
    }
}
