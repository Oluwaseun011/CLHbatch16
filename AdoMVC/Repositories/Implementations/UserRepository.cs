using MySql.Data.MySqlClient;
using StudentMgtApp.Entities;
using StudentMgtApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgtApp.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly Startup _sp;
        public UserRepository(Startup sp)
        {
            _sp = sp;
        }


        public User Create(User user)
        {
            using (var connect = _sp.Connection())
            {
                connect.Open();
                var querry = $"Insert into user (Id, Name, Email,Password,PhoneId,AddressId,RoleId,IsDeleted,DateCreated) values('{user.Id}', '{user.Name}', '{user.Email}','{user.Password}','{user.PhoneId}','{user.AddressId}','{user.RoleId}','{user.IsDeleted}','{user.DateCreated}');";
                var command = new MySqlCommand(querry, connect);
                var row = command.ExecuteNonQuery();
                if (row != -1)
                {
                    return user;
                }
                return null;
            }
        }

        public User Get(string email)
        {
            using (var connect = _sp.Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"select * from user where Email = @email;", connect);
                command.Parameters.AddWithValue("@email", email);
                var row = command.ExecuteReader();
                User user = new();
                while (row.Read())
                {
                    user.Id = Convert.ToString(row[0]);
                    user.Name = Convert.ToString(row[1]);
                    user.Email = Convert.ToString(row[2]);
                    user.Password = Convert.ToString(row[3]);
                    user.PhoneId = Convert.ToString(row[4]);
                    user.AddressId = Convert.ToString(row[5]);
                    user.RoleId = Convert.ToString(row[6]);
                }
                return user;
            }
        }

        public List<User> GetAll()
        {
            List<User> Users = new List<User>();
            using (var connect = _sp.Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"Select * From user;", connect);
                var row = command.ExecuteReader();
                while (row.Read())
                {
                    User user = new();
                    user.Id = Convert.ToString(row[0]);
                    user.Name = Convert.ToString(row[1]);
                    user.Email = Convert.ToString(row[2]);
                    user.Password = Convert.ToString(row[3]);
                    user.PhoneId = Convert.ToString(row[4]);
                    user.AddressId = Convert.ToString(row[5]);
                    user.RoleId = Convert.ToString(row[6]);

                    Users.Add(user);
                }

            }
            return Users;
        }
    }
}
