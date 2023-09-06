using AdoPract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoPract.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Student Create(Student student);
        Student Get(string id);
        List<Student> GetAll();
    }
}
