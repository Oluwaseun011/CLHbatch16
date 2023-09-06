
using StudentMgtApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgtApp.Repositories.Interfaces
{
    public interface IAddressRepository
    {
        Address Create(Address address);
        Address Get(string id);
        List<Address> GetAll();

    }
}
