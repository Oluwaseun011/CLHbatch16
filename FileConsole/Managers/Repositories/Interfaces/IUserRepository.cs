using FileHandling.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Repositories.Interfaces
{
    public interface IUserRepository
    {
        bool Check(Func<User, bool> expression);
        User Create(User user);
        User Get(string id);
        User Get(Func<User, bool> expression);
        List<User> GetAll();

        void AddToFile(User user);
        void RefreshFile();
        void ReadUsersFromFile();
    }
}
