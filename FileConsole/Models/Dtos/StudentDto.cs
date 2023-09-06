using FileHandling.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Models.Dtos
{
    public class StudentDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string BasicId { get; set; }
        public string Basic { get; set; }
        public string MatricNumber { get; set; }
        public Dictionary<string, int> Scores { get; set; } = new Dictionary<string, int>();
        public bool IsDeleted { get; set; }
    }

    public class CreateStudentRequestModel
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
    }

    public class UpdateStudentRequestModel
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; } = default!;
        public int Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
