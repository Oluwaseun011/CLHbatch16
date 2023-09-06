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
    public class BasicRepository : IBasicRepository
    {
        ApplicationContext _appContext = new ApplicationContext();
        FileAppContext _fileContext = new FileAppContext();

        public BasicRepository()
        {
            ReadBasicsFromFile();
        }

        public void AddToFile(Basic basic)
        {
            throw new NotImplementedException();
        }

        public bool Check(Func<Basic, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Basic Create(Basic basic)
        {
            throw new NotImplementedException();
        }

        public Basic Get(string id)
        {
            throw new NotImplementedException();
        }

        public Basic Get(Func<Basic, bool> expression)
        {
            throw new NotImplementedException();
        }

        public List<Basic> GetAll()
        {
            throw new NotImplementedException();
        }

        public void ReadBasicsFromFile()
        {
            throw new NotImplementedException();
        }

        public void RefreshFile()
        {
            throw new NotImplementedException();
        }
    }
}
