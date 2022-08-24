using PhoneMemberApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PhoneMemberApp.DataAccess
{
    public class InMemoryPersonDal : IPersonDal
    {
        private List<Person> _person;
        public InMemoryPersonDal()
        {
            _person = new List<Person>
            {
                //new Person{Id = 1, Name = "Gazi", Surname = "Hataş", PhoneNumber = 555555555},
                //new Person{Id = 2, Name = "Feyza", Surname = "aksirin", PhoneNumber = 555555555},
                //new Person{Id = 3, Name = "DemoUser", Surname = "aaa", PhoneNumber = 555555555},
                //new Person{Id = 4, Name = "Demo", Surname = "Hataş", PhoneNumber = 555555555},
                //new Person{Id = 5, Name = "Test", Surname = "Hataş", PhoneNumber = 555555555}

            };
        }
        public List<Person> GetAll()
        {
            return _person;
        }

        public void Add(Person persona)
        {
            _person.Add(persona);
        }

        public void Update(Person person)
        {
            Person personToUptade = _person.SingleOrDefault(c => c.Id == person.Id);

            personToUptade.Name = person.Name;
            personToUptade.Surname = person.Surname;
            personToUptade.PhoneNumber = person.PhoneNumber;

        }

        public void Delete(Person person)
        {
            Person personToDelete = _person.SingleOrDefault(c => c.Id == person.Id);
            _person.Remove(personToDelete);
        }

        public List<Person> GetById(Person person)
        {
            throw new NotImplementedException();
        }

    }
}
