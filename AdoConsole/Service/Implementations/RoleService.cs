using AdoPract.Dtos;
using AdoPract.Models;
using AdoPract.Repositories.Implementations;
using AdoPract.Repositories.Interfaces;
using AdoPract.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoPract.Service.Implementations
{
    public class RoleService : IRoleService
    {
        IRoleRepository roleRepository = new RoleRepository();
        public RoleDto Create(CreateRoleRequestModel model)
        {
            var exists = roleRepository.GetByName(model.Name);
            if(exists != null)
            {
                Console.WriteLine("already exist");
            }

            var role = new Role
            {
                Name = model.Name,
                Description = model.Description,
            };

            roleRepository.Create(role);

            return new RoleDto
            {
                Id = role.Id,
                Name = role.Name,
                Description = role.Description,
            };
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
