using FileHandling.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Services.Interfaces
{
    public interface IPrincipalService
    {
        PrincipalDto Create(CreatePrincipalRequestModel model);
        PrincipalDto Get(string id);
        List<PrincipalDto> GetAll();
        bool Delete(string id);
    }
}
