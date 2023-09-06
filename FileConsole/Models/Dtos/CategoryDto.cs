using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Models.Dtos
{
    public class CategoryDto
    {
        public string Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class CreateCategoryRequestModel
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; }
    }
}
