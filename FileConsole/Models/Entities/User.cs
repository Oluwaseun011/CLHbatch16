using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHandling.Models.Enums;

namespace FileHandling.Models.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; } = default!;
        public string AddressId { get; set; }
        public string RoleId { get; set; }

        public static User ToUser(string str)
        {
            var model = str.Split('\t');
            var user = new User()
            {
                Id = model[0],
                Name = model[1],
                Email = model[2],
                Password = model[3],
                Gender = (Gender)Enum.Parse(typeof(Gender), model[4]),
                PhoneNumber = model[5],
                AddressId = model[6],
                RoleId = model[7],
                IsDeleted = bool.Parse(model[8]),
            };
            return user;
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Email}\t{Password}\t{Gender}\t{PhoneNumber}\t{AddressId}\t{RoleId}\t{IsDeleted}";
        }

    }
}
