using FileHandling.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Repositories.Interfaces
{
    public interface IPrincipalRepository
    {
        bool Check(Func<Principal, bool> expression);
        Principal Create(Principal principal);
        Principal Get(string id);
        Principal Get(Func<Principal, bool> expression);
        List<Principal> GetAll();

        void AddToFile(Principal principal);
        void RefreshFile();
        void ReadPrincipalsFromFile();
    }
}
