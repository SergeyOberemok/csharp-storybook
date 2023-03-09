using CSharpStorybook.Models;

namespace CSharpStorybook.Patterns.Factory
{
    interface IPersonFactory
    {
        public IEnumerable<Person> GetPersons(int length);
    }

    interface IAsyncPersonFactory
    {
        public IAsyncEnumerable<Person> GetPersons(int length);
    }
}
