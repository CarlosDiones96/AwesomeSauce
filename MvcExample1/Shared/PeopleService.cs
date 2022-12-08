using System.Collections.Generic;

namespace Shared
{
    public class PeopleService : IPeopleService
    {
        public void Create(Person person)
        {
           // TODO
        }

        public bool DoesExists(int id)
        {
            return true;
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return new Person[]
            {
                new Person {Id = 1, Name = "Angel"},
                new Person {Id = 2, Name = "Maria"},
                new Person {Id = 3, Name = "Sam"},
            };
        }

        public Person GetOnePerson(int id)
        {
            return new Person { Id = 2, Name = "Maria" };
        }

        public bool Validated(Person id)
        {
            return true;
        }
    }
}
