using AdoPract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoPract.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        Role Create(Role role);
        Role Get(string id);
        Role GetByName(string name);
        List<Role> GetAll();
    }
}
