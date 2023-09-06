using FileHandling.Managers.Repositories.Implementations;
using FileHandling.Managers.Repositories.Interfaces;
using FileHandling.Managers.Services.Interfaces;
using FileHandling.Models.Dtos;
using FileHandling.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Managers.Services.Implementations
{
    public class StudentService : IStudentService
    {
        IStudentRepository studentRepo = new StudentRepository();
        IUserRepository userRepo = new UserRepository();
        IAddressRepository addressRepo = new AddressRepository();

        public StudentDto Create(CreateStudentRequestModel model)
        {
            var exists = userRepo.Check(a => a.Email == model.Email && a.IsDeleted == false);
            if (exists)
            {
                Console.WriteLine($"user with email {model.Email} already exists");
                return null;
            }

            var address = new Address()
            {
                Number = model.Number,
                Street = model.Street,
                City = model.City,
                State = model.State,
                IsDeleted = false,
            };
            addressRepo.Create(address);

            var user = new User()
            {
                AddressId = address.Id,
                Name = model.Name,
                Email = model.Email,
                Password = model.Password,
                PhoneNumber = model.PhoneNumber,
                Gender = model.Gender,
                IsDeleted = false,
            };

            userRepo.Create(user);

            var student = new Student()
            {
                UserId = user.Id,
                MatricNumber = GenerateMatricNumber(),
                Scores = new Dictionary<string, int>(),
                IsDeleted = false

            };

            studentRepo.Create(student);

            return new StudentDto
            {
                Name = user.Name,
                MatricNumber = student.MatricNumber,
                Scores = student.Scores,
                UserId = user.Id,
                
            };
        }

        public bool Delete(string id)
        {
            var student = studentRepo.Get(id);
            var user = userRepo.Get(student.UserId);
            var address = addressRepo.Get(user.AddressId);
            address.IsDeleted = true;
            user.IsDeleted = true;
            student.IsDeleted = true;
            return true;

            //cascade //restrict in database
            //soft Delete
        }

        public StudentDto Get(string id)
        {
            var student = studentRepo.Get(id);
            var user = userRepo.Get(student.UserId);
            var address = addressRepo.Get(user.AddressId);

            return new StudentDto
            {
                UserId = user.Id,
                MatricNumber = student.MatricNumber,
                Scores = student.Scores,
                Name = user.Name,
            };
        }

        public List<StudentDto> GetAll()
        {
            throw new NotImplementedException();
        }

        private string GenerateMatricNumber()
        {
            return $"CLH/2023/{new Random().Next(100, 999)}";
        }
    }
}
