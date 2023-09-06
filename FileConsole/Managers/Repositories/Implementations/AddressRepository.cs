using FileHandling.FileContext;
using FileHandling.Managers.Repositories.Interfaces;
using FileHandling.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Repositories.Implementations
{
    public class AddressRepository : IAddressRepository
    {
        ApplicationContext _appContext = new ApplicationContext();
        FileAppContext _fileContext = new FileAppContext();


        public AddressRepository()
        {
            ReadAddressesFromFile();
        }


        public bool Check(Func<Address, bool> expression)
        {
            return _appContext.Addresses.Any(expression);
        }

        public Address Create(Address address)
        {
            _appContext.Addresses.Add(address);
            using (var str = new StreamWriter(_fileContext.Addresses, true))
            {
                str.WriteLine(address.ToString());
            }
            return address;
        }

        public Address Get(string id)
        {
            var address = _appContext.Addresses.SingleOrDefault(a => a.Id == id && a.IsDeleted == false);
            return address;
        }

        public Address Get(Func<Address, bool> expression)
        {
            var address = _appContext.Addresses.SingleOrDefault(expression);
            return address;
        }

        public List<Address> GetAll()
        {
            return _appContext.Addresses.Where(a => a.IsDeleted == false).ToList();
        }

        public void AddToFile(Address address)
        {
            try
            {
                using (StreamWriter stream = new StreamWriter(_fileContext.Addresses, true))
                {
                    stream.WriteLine(address.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void ReadAddressesFromFile()
        {
            try
            {
                var addresses = File.ReadAllLines(_fileContext.Addresses);
                foreach (var address in addresses)
                {
                    _appContext.Addresses.Add(Address.ToAddress(address));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RefreshFile()
        {
            try
            {
                using (StreamWriter str = new StreamWriter(_fileContext.Addresses, false))
                {
                    foreach (var item in _appContext.Addresses)
                    {
                        str.WriteLine(item.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
