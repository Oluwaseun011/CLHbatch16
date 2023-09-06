using FileHandling.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Services.Interfaces
{
    public interface ICategoryService
    {
        CategoryDto Create(CreateCategoryRequestModel model);
        CategoryDto Get(string id);
        List<CategoryDto> GetAll();
        bool Delete(string id);
    }
}
