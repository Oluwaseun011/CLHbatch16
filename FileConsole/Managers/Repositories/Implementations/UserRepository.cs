using FileHandling.FileContext;
using FileHandling.Managers.Repositories.Interfaces;
using FileHandling.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        ApplicationContext _appContext = new ApplicationContext();
        FileAppContext _fileContext = new FileAppContext();
        public UserRepository() 
        { 
            ReadUsersFromFile();
        }
        public void AddToFile(User user)
        {
            throw new NotImplementedException();
        }

        public bool Check(Func<User, bool> expression)
        {
            throw new NotImplementedException();
        }

        public User Create(User user)
        {
            throw new NotImplementedException();
        }

        public User Get(string id)
        {
            throw new NotImplementedException();
        }

        public User Get(Func<User, bool> expression)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void ReadUsersFromFile()
        {
            throw new NotImplementedException();
        }

        public void RefreshFile()
        {
            throw new NotImplementedException();
        }
    }
}
