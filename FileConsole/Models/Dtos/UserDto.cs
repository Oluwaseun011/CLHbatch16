using FileHandling.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Models.Dtos
{
    public class UserDto
    {
        public string Id { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; } 
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressId { get; set; }
        public string RoleId { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class LoginRequestModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class LoginResponseModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public string RoleName { get; set; }
    }
}
