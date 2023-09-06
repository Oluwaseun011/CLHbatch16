using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgtApp.Entities
{
    public abstract class AuditableEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().Substring(0,5);
        public int IsDeleted { get; set; } = 0;
        public string DateCreated { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

    }
}
