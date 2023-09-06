using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Models.Entities
{
    public class Address : BaseEntity
    {
        public int Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public static Address ToAddress(string str)
        {
            var model = str.Split('\t');
            var address = new Address()
            {
                Id = model[0],
                Number = int.Parse(model[1]),
                Street = model[2],
                City = model[3],
                State = model[4],
                IsDeleted = bool.Parse(model[5]),
            };

            return address;
        }

        public override string ToString()
        {
            return $"{Id}\t{Number}\t{Street}\t{City}\t{State}\t{IsDeleted}";
        }
    }
}
