using FileHandling.Menu;
using FileHandling.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FileHandling.Models.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; }

        public static Role ToRole(string str)
        {
            var model = str.Split('\t');
            var role = new Role()
            {
                Id = model[0],
                Name = model[1],
                Description = model[2],
                IsDeleted = bool.Parse(model[3]),
            };
            return role;
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Description}\t{IsDeleted}";
        }
    }
}
