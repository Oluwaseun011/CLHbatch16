using FileHandling.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.FileContext
{
    public class ApplicationContext
    {
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<User> Users { get; set; } = new List<User>();
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
