using FileHandling.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        bool Check(Func<Role, bool> expression);
        Role Create(Role role);
        Role Get(string id);
        Role Get(Func<Role, bool> expression);
        List<Role> GetAll();

        void AddToFile(Role role);
        void RefreshFile();
        void ReadRolesFromFile();
    }
}
