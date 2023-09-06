
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoPract
{
    
    public class Startup
    {

        public string connectionStrings = "server = localhost; user = root; database = adopract; password = pa$$word";

        public MySqlConnection Connection()
        {
            return new MySqlConnection(connectionStrings);
        }

        public void CreateSchema()
        {
            string connectionString = "server = localhost; user = root; password = pa$$word";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var querry = "create schema if not exists adopract";
                var command = new MySqlCommand(querry, connection);
                int row = command.ExecuteNonQuery();
            }
        }

        public void CreateTable(string tableQuerry)
        {
            using (var connection = Connection())
            {
                connection.Open();
                var command = new MySqlCommand(tableQuerry, connection);
                int row = command.ExecuteNonQuery();
            }
        }

        public void CreateRoleTable()
        {
            var querry = "create table if not exists role(Id varchar(50) not null unique,Name varchar(50) unique,Description varchar(150),IsDeleted bool, DateCreated Datetime, primary key(Id));";
            CreateTable(querry);

        }


        public void CreateAddressTable()
        {
            var querry = "create table if not exists address(Id varchar(50) not null unique,Number int,Street varchar(50),City varchar(50),State varchar(50),PostalCode varchar(50),IsDeleted bool,DateCreated Datetime, primary key(Id));";
            CreateTable(querry);
        }

        public void CreatePhoneTable()
        {
            var querry = "create table if not exists phone(Id varchar(50) not null unique,CountryCode varchar(50),PhoneNumber varchar(50) unique,IsDeleted bool, DateCreated Datetime, primary key(Id));";
            CreateTable(querry);
        }

        public void CreateStudentTable()
        {
            var querry = "create table if not exists student(Id varchar(50) not null unique,UserId varchar(50) ,MatricNumber varchar(150) unique,IsDeleted bool,DateCreated Datetime, primary key(Id), foreign key(UserId) references User(Id));";
            CreateTable(querry);
        }

        public void CreateUserTable()
        {
            var querry = "create table if not exists user(Id varchar(50) not null unique,Name varchar(50) ,Email varchar(150) unique,Password varchar(50),PhoneId varchar(50),AddressId varchar(50),RoleId varchar(50),IsDeleted bool, DateCreated Datetime, primary key(Id), foreign key(PhoneId) references phone(Id),foreign key(AddressId) references address(Id), foreign key(RoleId) references role(Id));";
            CreateTable(querry);
        }
    }
}
