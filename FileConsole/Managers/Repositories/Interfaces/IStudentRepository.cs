using FileHandling.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        bool Check(Func<Student, bool> expression);
        Student Create(Student student);
        Student Get(string id);
        Student Get(Func<Student, bool> expression);
        List<Student> GetAll();

        void AddToFile(Student student);
        void RefreshFile();
        void ReadStudentsFromFile();
    }
}
