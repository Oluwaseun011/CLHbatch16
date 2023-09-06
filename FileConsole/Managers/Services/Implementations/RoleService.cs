using FileHandling.Managers.Repositories.Implementations;
using FileHandling.Managers.Repositories.Interfaces;
using FileHandling.Managers.Services.Interfaces;
using FileHandling.Models.Dtos;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Services.Implementations
{
    public class RoleService : IRoleService
    {
        IRoleRepository roleRepo = new RoleRepository();
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public RoleDto Create(CreateRoleRequestModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public RoleDto Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<RoleDto> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
