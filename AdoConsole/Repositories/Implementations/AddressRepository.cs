using AdoPract.Models;
using AdoPract.Repositories.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoPract.Repositories.Implementations
{
    public class AddressRepository : IAddressRepository
    {
        Startup db = new();
        public Address Create(Address address)
        {
            using (var connect = db.Connection())
            {
                connect.Open();
                var querry = $"Insert into address (Id, Number, Street , City, State,PostalCode, DateCreated) values('{address.Id}', '{address.Number}', '{address.Street}', '{address.City}','{address.State}','{address.PostalCode}');";
                var command = new MySqlCommand(querry, connect);
                var row = command.ExecuteNonQuery();
                if (row != -1)
                {
                    return address;
                }
                return null;
            }
        }

        public Address Get(string id)
        {
            using (var connect = db.Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"select * from address where Id = @id;", connect);
                command.Parameters.AddWithValue("@id", id);
                var row = command.ExecuteReader();
                Address address = new();
                while (row.Read())
                {
                    address.Id = Convert.ToString(row[0]);
                    address.Number = Convert.ToInt32(row[1]);
                    address.Street = Convert.ToString(row[2]);
                    address.City = Convert.ToString(row[3]);
                    address.State = Convert.ToString(row[4]);
                    address.PostalCode = Convert.ToString(row[5]);
                }
                return address;
            }
        }

        public List<Address> GetAll()
        {
            List<Address> Addresses = new List<Address>();
            using (var connect = db.Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"Select * From address;", connect);
                var row = command.ExecuteReader();
                while (row.Read())
                {
                    Address address = new Address();
                    address.Id = Convert.ToString(row[0]);
                    address.Number = Convert.ToInt32(row[1]);
                    address.Street = Convert.ToString(row[2]);
                    address.City = Convert.ToString(row[3]);
                    address.State = Convert.ToString(row[4]);
                    address.PostalCode = Convert.ToString(row[5]);

                    Addresses.Add(address);
                }

            }
            return Addresses;

        }
    }
}
