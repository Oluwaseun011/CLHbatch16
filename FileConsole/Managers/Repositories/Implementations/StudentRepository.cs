using FileHandling.FileContext;
using FileHandling.Managers.Repositories.Interfaces;
using FileHandling.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Repositories.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        ApplicationContext _appContext = new ApplicationContext();
        FileAppContext _fileContext = new FileAppContext();

        public StudentRepository()
        {
            ReadStudentsFromFile();
        }
        public void AddToFile(Student student)
        {
            throw new NotImplementedException();
        }

        public bool Check(Func<Student, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Student Create(Student student)
        {
            throw new NotImplementedException();
        }

        public Student Get(string id)
        {
            throw new NotImplementedException();
        }

        public Student Get(Func<Student, bool> expression)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public void ReadStudentsFromFile()
        {
            throw new NotImplementedException();
        }

        public void RefreshFile()
        {
            throw new NotImplementedException();
        }
    }
}
