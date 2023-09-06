using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentMgtApp.Entities
{
    public class Phone : AuditableEntity
    {
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
