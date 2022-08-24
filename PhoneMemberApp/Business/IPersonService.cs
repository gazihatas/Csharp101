using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using PhoneMemberApp.Entities;

namespace PhoneMemberApp.Business
{
    public interface IPersonService
    { 
        List<Person> GetAll();
    }
}
