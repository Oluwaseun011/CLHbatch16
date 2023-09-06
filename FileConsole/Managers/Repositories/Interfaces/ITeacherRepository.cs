using FileHandling.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Repositories.Interfaces
{
    public interface ITeacherRepository
    {
        bool Check(Func<Teacher, bool> expression);
        Teacher Create(Teacher teacher);
        Teacher Get(string id);
        Teacher Get(Func<Teacher, bool> expression);
        List<Teacher> GetAll();

        void AddToFile(Teacher teacher);
        void RefreshFile();
        void ReadTeachersFromFile();
    }
}
