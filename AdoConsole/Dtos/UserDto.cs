using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoPract.Dtos
{
    public class UserDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressId { get; set; }
        public string FullAddress { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
