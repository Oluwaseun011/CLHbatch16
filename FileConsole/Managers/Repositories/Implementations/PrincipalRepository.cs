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
    public class PrincipalRepository : IPrincipalRepository
    {
        ApplicationContext _appContext = new ApplicationContext();
        FileAppContext _fileContext = new FileAppContext();

        public PrincipalRepository()
        {
            ReadPrincipalsFromFile();
        }
        public void AddToFile(Principal principal)
        {
            throw new NotImplementedException();
        }

        public bool Check(Func<Principal, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Principal Create(Principal principal)
        {
            throw new NotImplementedException();
        }

        public Principal Get(string id)
        {
            throw new NotImplementedException();
        }

        public Principal Get(Func<Principal, bool> expression)
        {
            throw new NotImplementedException();
        }

        public List<Principal> GetAll()
        {
            throw new NotImplementedException();
        }

        public void ReadPrincipalsFromFile()
        {
            throw new NotImplementedException();
        }

        public void RefreshFile()
        {
            throw new NotImplementedException();
        }
    }
}
