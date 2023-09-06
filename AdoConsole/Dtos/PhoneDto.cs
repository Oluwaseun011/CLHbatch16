using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoPract.Dtos
{
    public class PhoneDto
    {
        public string Id { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
