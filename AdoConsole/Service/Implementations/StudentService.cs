using AdoPract.Dtos;
using AdoPract.Models;
using AdoPract.Repositories.Implementations;
using AdoPract.Repositories.Interfaces;
using AdoPract.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoPract.Service.Implementations
{
    public class StudentService : IStudentService
    {
        IStudentRepository studentRepository = new StudentRepository();
        IUserRepository userRepository = new UserRepository();
        IRoleRepository roleRepository = new RoleRepository();
        IAddressRepository addressRepository = new AddressRepository();
        IPhoneRepository phoneRepository = new PhoneRepository();
        public StudentDto Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<StudentDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public StudentDto Register(RegisterStudentRequestModel request)
        {
            var exists = userRepository.Get(request.Email);
            if (exists != null)
            {
                return null;
            }
            var address = new Address
            {
                Number = request.Number,
                Street = request.Street,
                City = request.City,
                State = request.State,
                PostalCode = request.PostalCode,
            };
            var phone = new Phone
            {
                CountryCode = request.CountryCode,
                PhoneNumber = request.PhoneNumber,
            };

            var roleId = roleRepository.GetByName("Student").Id;

            var user = new User
            {
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                PhoneId = phone.Id,
                AddressId = address.Id,
                RoleId = roleId,

            };

            var student = new Student
            {
                UserId = user.Id,
                RegNumber = $"clh/{new Random().Next(1000, 9999)}",
            };

            addressRepository.Create(address);
            phoneRepository.Create(phone);
            userRepository.Create(user);
            studentRepository.Create(student);

            return new StudentDto
            {
                Name = user.Name,
                Id = student.Id,
                RegNumber = student.RegNumber,
                UserId = user.Id,
            };
            
        }
    }
}
