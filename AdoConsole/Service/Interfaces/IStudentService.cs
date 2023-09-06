using AdoPract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoPract.Service.Interfaces
{
    public interface IStudentService
    {
        StudentDto Register(RegisterStudentRequestModel request);
        StudentDto Get(string id);
        List<StudentDto> GetAll();  
    }
}
