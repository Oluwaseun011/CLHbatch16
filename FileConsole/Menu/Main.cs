using FileHandling.Managers.Services.Implementations;
using FileHandling.Managers.Services.Interfaces;
using FileHandling.Models.Dtos;
using FileHandling.Models.Entities;
using FileHandling.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Menu
{
    public class Main
    {
        IStudentService studentService = new StudentService();
        IUserService userService = new UserService();
        IRoleService roleService = new RoleService();
        public void MainMenu()
        {
            Console.WriteLine(@"Press 1 to Register\nPress 2 to Login");
            int opt = int.Parse(Console.ReadLine());
            if(opt == 1)
            {
                RegisterMenu();
            }
            else if (opt == 2)
            {
                LoginMenu();
            }
            else
            {
                Console.WriteLine("wrong input");
            }
        }

        public void RegisterMenu()
        {
            Console.WriteLine("===>Address Info<===");
            Console.Write("Enter home number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter street: ");
            string street = Console.ReadLine();
            Console.Write("Enter city: ");
            string city = Console.ReadLine();
            Console.Write("Enter state: ");
            string state = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("===>Persornal Info<===");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your email address: ");
            string email = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Console.Write("Enter 1 for Male, 2 for Female: ");
            int gender = int.Parse(Console.ReadLine());
            Console.Write("Enter your phone number: ");
            string phone = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("===>Subjects<===");
            List<string> subjects = new List<string>();
            Console.Write("how many subjects do you offer: ");
            int offer = int.Parse(Console.ReadLine());
            for(int i = 1; i <= offer; i++)
            {
                Console.Write($"enter subjct {i}");
                var subj = Console.ReadLine();
                subjects.Add(subj);
            }

            var createStudent = new CreateStudentRequestModel()
            {
                City = city,
                Email = email,
                Gender = (Gender)gender,
                Name = name,
                Number = num,
                Password = password,
                PhoneNumber = phone,
                State = state,
                Street = street,
            };

            var responce = studentService.Create(createStudent);
            Console.WriteLine(responce != null? $"Congratulations {responce.Name}, your matric no is {responce.MatricNumber}" : "registration not successful");

        }

        public void LoginMenu()
        {
            Console.WriteLine("===>Persornal Info<===");
            Console.Write("Enter your email address: ");
            string email = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            var request = new LoginRequestModel
            {
                Email = email,
                Password = password,
            };

            var response = userService.Login(request);
            if(response == null)
            {
                Console.WriteLine("wrong cridentials");
                LoginMenu();
            }
            else
            {
                if(response.RoleName == "SuperAdmin")
                {
                    SuperAdmin sp = new();
                    sp.MainMenu();
                }
                else if(response.RoleName == "Principal")
                {
                    Principal p = new();
                    p.MainMenu();
                }
                else if (response.RoleName == "Teacher")
                {
                    Teacher t = new();
                    t.MainMenu();
                }
                else if (response.RoleName == "Student")
                {
                    Student s = new();
                    s.MainMenu();
                }
            }

        }

    }
}
