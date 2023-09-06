using FileHandling.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Repositories.Interfaces
{
    public interface IBasicRepository
    {
        bool Check(Func<Basic, bool> expression);
        Basic Create(Basic basic);
        Basic Get(string id);
        Basic Get(Func<Basic, bool> expression);
        List<Basic> GetAll();

        void AddToFile(Basic basic);
        void RefreshFile();
        void ReadBasicsFromFile();

    }
}
