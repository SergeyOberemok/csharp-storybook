using CSharpStorybook.Models;
using System.Text.Json;

namespace CSharpStorybook.Patterns.Factory
{
    public class HttpPersonFactory : IAsyncPersonFactory
    {
        private static HttpClient _http { get; set; }

        public async IAsyncEnumerable<Person> GetPersons(int length = 10)
        {
            string url = "https://jsonplaceholder.typicode.com/users";
            length = length > 0 ? length : 0;

            for (int i = 0; i < length; i++)
            {
                var response = await _http.GetStringAsync($"{url}/{i + 1}");

                var person = JsonSerializer.Deserialize<Person>(response, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                yield return person;
            }
        }
    }
}
