using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoPract.Models
{
    public class Phone : AuditableEntity
    {
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
