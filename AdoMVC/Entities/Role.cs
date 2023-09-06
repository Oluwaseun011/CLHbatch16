using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgtApp.Entities
{
    public class Role : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
