using FileHandling.Models.Dtos;
using FileHandling.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Services.Interfaces
{
    public interface IUserService
    {
        LoginResponseModel Login(LoginRequestModel model);
        UserDto Get(string id);
        List<UserDto> GetUsers();
    }
}
