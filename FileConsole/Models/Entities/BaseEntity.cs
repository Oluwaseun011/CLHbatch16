using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Models.Entities  
{
    public abstract class BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().Trim().Substring(0,3);
        public bool IsDeleted { get; set; }
    }
}
