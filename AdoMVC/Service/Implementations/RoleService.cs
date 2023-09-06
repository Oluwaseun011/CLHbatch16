using StudentMgtApp.Dtos;
using StudentMgtApp.Entities;
using StudentMgtApp.Repositories.Implementations;
using StudentMgtApp.Repositories.Interfaces;
using StudentMgtApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgtApp.Service.Implementations
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public RoleDto Create(CreateRoleRequestModel model)
        {
            var exists = _roleRepository.GetByName(model.Name);
            if(exists != null)
            {
                Console.WriteLine("already exist");
            }

            var role = new Role
            {
                Name = model.Name,
                Description = model.Description,
            };

            _roleRepository.Create(role);

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
