using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using PhoneMemberApp.DataAccess;
using PhoneMemberApp.Entities;

namespace PhoneMemberApp.Business
{
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }
        public List<Person> GetAll()
        {
           return _personDal.GetAll();
        }

       
    }
}
