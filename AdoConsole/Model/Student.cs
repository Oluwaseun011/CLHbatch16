using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoPract.Models
{
    public class Student : AuditableEntity
    {
        public string UserId { get; set; }
        public string RegNumber { get; set; }
    }
}
