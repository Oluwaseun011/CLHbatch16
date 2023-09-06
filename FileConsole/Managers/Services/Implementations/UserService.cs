using FileHandling.Managers.Repositories.Implementations;
using FileHandling.Managers.Repositories.Interfaces;
using FileHandling.Managers.Services.Interfaces;
using FileHandling.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Services.Implementations
{
    public class UserService : IUserService
    {
        IUserRepository userRepo = new UserRepository();
        IRoleRepository roleRepo = new RoleRepository();

        public UserDto Get(string id)
        {
            var user = userRepo.Get(id);
            return new UserDto
            {

            };
        }

        public List<UserDto> GetUsers()
        {
            throw new NotImplementedException();
        }

        public LoginResponseModel Login(LoginRequestModel model)
        {
            var login = userRepo.Get(a => a.Email == model.Email && a.Password == model.Password);
            if(login != null)
            {
                return new LoginResponseModel
                {
                    FullName = login.Name,
                    Gender = login.Gender,
                    Email = login.Email,
                    RoleName = roleRepo.Get(login.RoleId).Name,  
                };
            }
            return null;
            
        }
    }
}
