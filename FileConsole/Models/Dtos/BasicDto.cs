using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Models.Dtos
{
    public class BasicDto
    {
        public string Id { get; set; }
        public string CategoryId { get; set; }
        public string Name { get; set; } = default!;
        public List<string> Subjects { get; set; } = new List<string>();
        public bool IsDeleted { get; set; }
    }

    public class CreateBasicRequestModel
    {
        public string CategoryId { get; set; }
        public string Name { get; set; } = default!;
        public List<string> Subjects { get; set; } = new List<string>();
    }
}
