// See https://aka.ms/new-console-template for more information
using AdoPract;
using AdoPract.Dtos;
using AdoPract.Models;
using AdoPract.Service.Implementations;




Startup st = new();
st.CreateSchema();
st.CreateRoleTable();
st.CreateAddressTable();
st.CreatePhoneTable();
st.CreateUserTable();
st.CreateStudentTable();



//Console.WriteLine("enter role name");
//string roleName = Console.ReadLine();
//Console.WriteLine("enter role description");
//string des = Console.ReadLine();

//RoleService rl = new RoleService();
//rl.Create(new CreateRoleRequestModel()
//{
//    Name = roleName,
//    Description = des,
//});


//Console.WriteLine("===>Address Info<===");
//Console.Write("Enter home number: ");
//int num = int.Parse(Console.ReadLine());
//Console.Write("Enter street: ");
//string street = Console.ReadLine();
//Console.Write("Enter city: ");
//string city = Console.ReadLine();
//Console.Write("Enter state: ");
//string state = Console.ReadLine();
//Console.Write("Enter code: ");
//string pcode = Console.ReadLine();
//Console.WriteLine();
//Console.WriteLine("===>Persornal Info<===");
//Console.Write("Enter your name: ");
//string name = Console.ReadLine();
//Console.Write("Enter your email address: ");
//string email = Console.ReadLine();
//Console.Write("Enter password: ");
//string password = Console.ReadLine();
//Console.Write("Enter your country code: ");
//string ccode = Console.ReadLine();
//Console.Write("Enter your phone number: ");
//string phone = Console.ReadLine();

//StudentService ss = new StudentService();
//ss.Register(new RegisterStudentRequestModel
//{
//    Name = name,
//    City = city,
//    CountryCode = ccode,
//    Email = email,
//    Number = num,
//     Password = password,
//     PhoneNumber = phone,
//     PostalCode = pcode,
//     State = state,
//     Street = street,
     
//});