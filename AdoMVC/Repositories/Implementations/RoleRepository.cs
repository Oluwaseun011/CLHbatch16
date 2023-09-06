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
    public class RoleRepository : IRoleRepository
    {
        private readonly Startup _st;
        public RoleRepository(Startup st)
        {
            _st = st;
        }

        public Role Create(Role role)
        {
            using (var connect = _st.Connection())
            {
                connect.Open();
                var querry = $"Insert into role (Id, Name, Description,IsDeleted, DateCreated) values('{role.Id}', '{role.Name}', '{role.Description}', '{role.IsDeleted}', '{role.DateCreated}');";
                var command = new MySqlCommand(querry, connect);
                var row = command.ExecuteNonQuery();
                if (row != -1)
                {
                    return role;
                }
                return null;
            }
        }

        public Role Get(string id)
        {
            using (var connect = _st.Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"select * from role where Id = @id;", connect);
                command.Parameters.AddWithValue("@id", id);
                var row = command.ExecuteReader();
                Role role = new();
                while (row.Read())
                {
                    role.Id = Convert.ToString(row[0]);
                    role.Name = Convert.ToString(row[1]);
                    role.Description = Convert.ToString(row[2]);
                }
                return role;
            }
        }

        public List<Role> GetAll()
        {
            List<Role> Roles = new List<Role>();
            using (var connect = _st.Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"Select * From role;", connect);
                var row = command.ExecuteReader();
                while (row.Read())
                {
                    Role role = new Role();
                    role.Id = Convert.ToString(row[0]);
                    role.Name = Convert.ToString(row[1]);
                    role.Description = Convert.ToString(row[2]);

                    Roles.Add(role);
                }

            }
            return Roles;
        }

        public Role GetByName(string name)
        {
            using (var connect = _st.Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"select * from role where Name = @name;", connect);
                command.Parameters.AddWithValue("@name", name);
                var row = command.ExecuteReader();
                Role role = new();
                while (row.Read())
                {
                    role.Id = Convert.ToString(row[0]);
                    role.Name = Convert.ToString(row[1]);
                    role.Description = Convert.ToString(row[2]);
                }
                return role;
            }
        }
    }
}
