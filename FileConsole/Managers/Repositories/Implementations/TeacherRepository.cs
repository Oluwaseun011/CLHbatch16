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
    public class TeacherRepository : ITeacherRepository
    {
        ApplicationContext _appContext = new ApplicationContext();
        FileAppContext _fileContext = new FileAppContext();

        public TeacherRepository()
        {
            ReadTeachersFromFile();
        }
        public void AddToFile(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public bool Check(Func<Teacher, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Teacher Create(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public Teacher Get(string id)
        {
            throw new NotImplementedException();
        }

        public Teacher Get(Func<Teacher, bool> expression)
        {
            throw new NotImplementedException();
        }

        public List<Teacher> GetAll()
        {
            throw new NotImplementedException();
        }

        public void ReadTeachersFromFile()
        {
            throw new NotImplementedException();
        }

        public void RefreshFile()
        {
            throw new NotImplementedException();
        }
    }
}
