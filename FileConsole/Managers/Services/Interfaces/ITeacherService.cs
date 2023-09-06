using FileHandling.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Services.Interfaces
{
    public interface ITeacherService
    {
        TeacherDto Create(CreateTeacherRequestModel model);
        TeacherDto Get(string id);
        List<TeacherDto> GetAll();
        bool Delete(string id);
    }
}
