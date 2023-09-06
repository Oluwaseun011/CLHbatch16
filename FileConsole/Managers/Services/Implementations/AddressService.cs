using FileHandling.Managers.FileRepositories.Implementations;
using FileHandling.Managers.FileRepositories.Interfaces;
using FileHandling.Managers.Repositories.Implementations;
using FileHandling.Managers.Repositories.Interfaces;
using FileHandling.Managers.Services.Interfaces;
using FileHandling.Models.Dtos;
using FileHandling.Models.Entities;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Services.Implementations
{
    public class AddressService : IAddressService
    {
        IAddressRepository addressRepo = new AddressRepository();
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public bool Delete(string id)
        {
            var address = addressRepo.Get(id);
            address.IsDeleted = true;
            addressRepo.RefreshFile();
            return true;
        }

        public AddressDto Get(string id)
        {
            var address = addressRepo.Get(id);
            return new AddressDto
            {
                Id = address.Id,
                City = address.City,
                Number = address.Number,
                State = address.State,
                Street = address.Street,
            };
        }

        public List<AddressDto> GetAll()
        {
            var addresses = addressRepo.GetAll();
            var listOfAddress = addresses.Select(a => new AddressDto
            {
                Id= a.Id,
                Street= a.Street,
                State= a.State,
                Number= a.Number,
                City= a.City,
            }).ToList();

            return listOfAddress;
        }
    }
}
