using FileHandling.FileContext;
using FileHandling.Managers.Repositories.Interfaces;
using FileHandling.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Repositories.Implementations
{
    public class RoleRepository : IRoleRepository
    {
        ApplicationContext _appContext = new ApplicationContext();
        FileAppContext _fileContext = new FileAppContext();

        public RoleRepository()
        {
            ReadRolesFromFile();
        }
        public void AddToFile(Role role)
        {
            throw new NotImplementedException();
        }

        public bool Check(Func<Role, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Role Create(Role role)
        {
            throw new NotImplementedException();
        }

        public Role Get(string id)
        {
            throw new NotImplementedException();
        }

        public Role Get(Func<Role, bool> expression)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetAll()
        {
            throw new NotImplementedException();
        }

        public void ReadRolesFromFile()
        {
            throw new NotImplementedException();
        }

        public void RefreshFile()
        {
            throw new NotImplementedException();
        }
    }
}
