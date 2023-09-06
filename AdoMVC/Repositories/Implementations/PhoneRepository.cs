
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
    public class PhoneRepository : IPhoneRepository
    {
        private readonly Startup _startup;
        public PhoneRepository(Startup startup)
        {
            _startup = startup;
        }


        public Phone Create(Phone phone)
        {
            using (var connect = _startup.Connection())
            {
                connect.Open();
                var querry = $"Insert into phone (Id, CountryCode, PhoneNumber,IsDeleted, DateCreated) values('{phone.Id}', '{phone.CountryCode}', '{phone.PhoneNumber}','{phone.IsDeleted}','{phone.DateCreated}');";
                var command = new MySqlCommand(querry, connect);
                var row = command.ExecuteNonQuery();
                if (row != -1)
                {
                    return phone;
                }
                return null;
            }
        }

        public Phone Get(string id)
        {
            using (var connect = _startup.Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"select * from phone where Id = @id;", connect);
                command.Parameters.AddWithValue("@id", id);
                var row = command.ExecuteReader();
                Phone phone = new();
                while (row.Read())
                {
                    phone.Id = Convert.ToString(row[0]);
                    phone.CountryCode = Convert.ToString(row[1]);
                    phone.PhoneNumber = Convert.ToString(row[2]);
                }
                return phone;
            }
        }

        public List<Phone> GetAll()
        {
            List<Phone> Phones = new List<Phone>();
            using (var connect = _startup.Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"Select * From phone;", connect);
                var row = command.ExecuteReader();
                while (row.Read())
                {
                    Phone phone = new Phone();
                    phone.Id = Convert.ToString(row[0]);
                    phone.CountryCode = Convert.ToString(row[1]);
                    phone.PhoneNumber = Convert.ToString(row[2]);

                    Phones.Add(phone);
                }

            }
            return Phones;
        }
    }
}
