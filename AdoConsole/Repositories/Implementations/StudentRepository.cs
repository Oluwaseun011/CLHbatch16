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
    public class StudentRepository : IStudentRepository
    {
        Startup db = new();
        public bool Check(Func<Student, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Student Create(Student student)
        {
            using (var connect = db.Connection())
            {
                connect.Open();
                var querry = $"Insert into student (Id, UserId, RegNumber, DateCreated) values('{student.Id}', '{student.UserId}', '{student.RegNumber}');";
                var command = new MySqlCommand(querry, connect);
                var row = command.ExecuteNonQuery();
                if (row != -1)
                {
                    return student;
                }
                return null;
            }
        }

        public Student Get(string id)
        {
            using (var connect = db.Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"select * from student where Id = @id;", connect);
                command.Parameters.AddWithValue("@id", id);
                var row = command.ExecuteReader();
                Student student = new();
                while (row.Read())
                {
                    student.Id = Convert.ToString(row[0]);
                    student.UserId = Convert.ToString(row[1]);
                    student.RegNumber = Convert.ToString(row[2]);
                }
                return student;
            }
        }

        public Student Get(Func<Student, bool> expression)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            List<Student> Students = new List<Student>();
            using (var connect = db.Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"Select * From student;", connect);
                var row = command.ExecuteReader();
                while (row.Read())
                {
                    Student student = new Student();
                    student.Id = Convert.ToString(row[0]);
                    student.UserId = Convert.ToString(row[1]);
                    student.RegNumber = Convert.ToString(row[2]);

                    Students.Add(student);
                }

            }
            return Students;
        }
    }
}
