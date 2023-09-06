using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgtApp.Entities
{
    public class User : AuditableEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneId { get; set; }
        public string AddressId { get; set; }
        public string RoleId { get; set; }
    }
}
