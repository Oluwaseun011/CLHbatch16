using StudentMgtApp.Dtos;
using StudentMgtApp.Entities;
using StudentMgtApp.Repositories.Implementations;
using StudentMgtApp.Repositories.Interfaces;
using StudentMgtApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgtApp.Service.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;
        private readonly IUserRepository userRepository;
        private readonly IRoleRepository roleRepository;
        private readonly IAddressRepository addressRepository;
        private readonly IPhoneRepository phoneRepository;

        public StudentService(IStudentRepository studentRepository, IUserRepository userRepository, IRoleRepository roleRepository, IAddressRepository addressRepository, IPhoneRepository phoneRepository)
        {
            this.studentRepository = studentRepository;
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
            this.addressRepository = addressRepository;
            this.phoneRepository = phoneRepository;
        }

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
            if (exists == null)
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

            //var roleId = roleRepository.GetByName("Student").Id;
            var roleId = "adfre";

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
