using FileHandling.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace FileHandling.Models.Entities
{
    public class Teacher : BaseEntity
    {
        public string UserId { get; set; }
        public string BasicId { get; set; }
        public string StaffNumber { get; set; }
        public Qualification Qualification { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{UserId}\t{BasicId}\t{StaffNumber}\t{Qualification}\t{IsDeleted}";
        }

        public static Teacher ToTeacher(string str)
        {
            var model = str.Split('\t');

            var teacher = new Teacher()
            {
                Id = model[0],
                UserId = model[1],
                BasicId = model[2],
                StaffNumber = model[3],
                Qualification = (Qualification)Enum.Parse(typeof(Qualification), model[4]),
                IsDeleted = bool.Parse(model[4]),
            };
            return teacher;
        }
    }
}
