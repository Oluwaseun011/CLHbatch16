using FileHandling.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Models.Dtos
{
    public class TeacherDto
    {
        public string Id { get; set; }  
        public string UserId { get; set; }
        public string BasicId { get; set; }
        public string StaffNumber { get; set; }
        public Qualification Qualification { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class CreateTeacherRequestModel
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; } = default!;
        public int Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string RoleId { get; set; }
        public string BasicId { get; set; }
        public Qualification Qualification { get; set; }
    }

    public class UpdateTeacherRequestModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string RoleId { get; set; }
        public string BasicId { get; set; }
        public Qualification Qualification { get; set; }
    }
}
