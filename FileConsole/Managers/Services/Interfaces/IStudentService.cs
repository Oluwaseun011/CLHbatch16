using FileHandling.Models.Dtos;
using FileHandling.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Services.Interfaces
{
    public interface IStudentService
    {
        StudentDto Create(CreateStudentRequestModel model);
        StudentDto Get(string id);
        List<StudentDto> GetAll();  
        bool Delete(string id);
    }
}
