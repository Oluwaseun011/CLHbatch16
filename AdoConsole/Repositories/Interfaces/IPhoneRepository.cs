using AdoPract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoPract.Repositories.Interfaces
{
    public interface IPhoneRepository
    {
        Phone Create(Phone phone);
        Phone Get(string id);
        List<Phone> GetAll();
    }
}
