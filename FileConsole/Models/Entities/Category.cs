using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Models.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; }

        public static Category ToCategory(string str)
        {
            var model = str.Split('\t');
            var category = new Category()
            {
                Id = model[0],
                Name = model[1],
                Description = model[2],
                IsDeleted = bool.Parse(model[3]),
            };
            return category;
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Description}\t{IsDeleted}";
        }
    }
}
