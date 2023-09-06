using AdoPract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoPract.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User Create(User user);
        User Get(string email);
        List<User> GetAll();
    }
}
