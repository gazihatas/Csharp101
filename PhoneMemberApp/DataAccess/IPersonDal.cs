using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneMemberApp.Entities;

namespace PhoneMemberApp.DataAccess
{
    public interface IPersonDal
    {
        List<Person> GetAll();
        void Add(Person person);
        void Update(Person person);
        void Delete(Person person);
    }
}
