using FluentAssertions;
using Xunit;

namespace CSharpStorybook.Flow
{
    public class AsyncAwaitTests
    {
        [Fact]
        public async void TestAsyncAwait()
        {
            int counter = 0;

            await Task.Run(() => counter++);

            counter.Should().NotBe(0);
            counter.Should().Be(1);
        }

        [Fact]
        public void TestInvokeVoidAsync()
        {
            IncreaseCounter();
        }

        private async void IncreaseCounter()
        {
            int counter = 0;

            await Task.Run(() => counter++);

            counter.Should().NotBe(0);
            counter.Should().Be(1);
        }
    }
}
