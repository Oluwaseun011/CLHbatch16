using StudentMgtApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgtApp.Service.Interfaces
{
    public interface IRoleService
    {
        RoleDto Create(CreateRoleRequestModel model);
        RoleDto Get(string id);
        List<RoleDto> GetAll();


    }
}
