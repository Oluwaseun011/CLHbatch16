using FileHandling.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Services.Interfaces
{
    public interface IBasicService
    {
        BasicDto Create(CreateBasicRequestModel model);
        BasicDto Get(string id);
        List<BasicDto> GetAll();
        bool Delete(string id);
    }
}
