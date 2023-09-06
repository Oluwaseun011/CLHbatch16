using FileHandling.Managers.Repositories.Implementations;
using FileHandling.Managers.Repositories.Interfaces;
using FileHandling.Managers.Services.Interfaces;
using FileHandling.Models.Dtos;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Services.Implementations
{
    public class BasicService : IBasicService
    {
        IBasicRepository basicRepo = new BasicRepository();
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public BasicDto Create(CreateBasicRequestModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public BasicDto Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<BasicDto> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
