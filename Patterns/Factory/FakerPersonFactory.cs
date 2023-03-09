using CSharpStorybook.Models;
using FakerDataSets = Bogus.DataSets;

namespace CSharpStorybook.Patterns.Factory
{
    public class FakerPersonFactory : IPersonFactory
    {
        public IEnumerable<Person> GetPersons(int length = 1)
        {
            length = length > 0 ? length : 0;
            Bogus.Faker faker = new Bogus.Faker();

            for (int i = 0; i < length; i++)
            {
                var gender = faker.Random.Bool() ? FakerDataSets.Name.Gender.Male : FakerDataSets.Name.Gender.Female;

                yield return new Person
                {
                    Name = faker.Name.FirstName(gender),
                    Username = faker.Name.LastName(gender),
                    Email = faker.Internet.Email(),
                    Gender = (Gender)gender,
                };
            }
        }
    }
}
