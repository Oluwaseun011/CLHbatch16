using FileHandling.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Repositories.Interfaces
{
    public interface IAddressRepository
    {
        bool Check(Func<Address, bool> expression);
        Address Create(Address address);
        Address Get(string id);
        Address Get(Func<Address, bool> expression);
        List<Address> GetAll();

        void AddToFile(Address address);
        void RefreshFile();
        void ReadAddressesFromFile();

    }
}
