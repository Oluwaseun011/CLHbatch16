using FileHandling.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        bool Check(Func<Category, bool> expression);
        Category Create(Category category);
        Category Get(string id);
        Category Get(Func<Category, bool> expression);
        List<Category> GetAll();

        void AddToFile(Category category);
        void RefreshFile();
        void ReadCategoriesFromFile();
    }
}
