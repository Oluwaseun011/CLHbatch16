using FileHandling.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Models.Entities
{
    public class Principal : BaseEntity
    {
        public string UserId { get; set; }
        public string StaffNumber { get; set; }
        public Qualification Qualification { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{UserId}\t{StaffNumber}\t{Qualification}\t{IsDeleted}";
        }

        public static Principal ToPrincipal(string str)
        {
            var model = str.Split('\t');

            var principal = new Principal()
            {
                Id = model[0],
                UserId = model[1],
                StaffNumber = model[2],
                Qualification = (Qualification)Enum.Parse(typeof(Qualification), model[3]),
                IsDeleted = bool.Parse(model[4]),
            };
            return principal;
        }
    }
}
