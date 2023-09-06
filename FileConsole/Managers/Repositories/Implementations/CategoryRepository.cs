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
    public class CategoryRepository : ICategoryRepository
    {
        ApplicationContext _appContext = new ApplicationContext();
        FileAppContext _fileContext = new FileAppContext();

        public CategoryRepository()
        {
            ReadCategoriesFromFile();
        }
        public void AddToFile(Category category)
        {
            throw new NotImplementedException();
        }

        public bool Check(Func<Category, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Category Create(Category category)
        {
            throw new NotImplementedException();
        }

        public Category Get(string id)
        {
            throw new NotImplementedException();
        }

        public Category Get(Func<Category, bool> expression)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void ReadCategoriesFromFile()
        {
            throw new NotImplementedException();
        }

        public void RefreshFile()
        {
            throw new NotImplementedException();
        }
    }
}
