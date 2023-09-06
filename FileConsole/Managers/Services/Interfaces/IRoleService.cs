using FileHandling.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Services.Interfaces
{
    public interface IRoleService
    {
        RoleDto Create(CreateRoleRequestModel model);
        RoleDto Get(string id);
        List<RoleDto> GetAll();
        bool Delete(string id);
    }
}
