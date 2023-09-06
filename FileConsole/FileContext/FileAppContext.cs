using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.FileContext
{
    public class FileAppContext
    {
        public string path = @"C:\Users\user\Desktop\FileHandling\Files";
        public string Addresses = @"C:\Users\user\Desktop\FileHandling\Files\Addresses.txt";
        public string Basics = @"C:\Users\user\Desktop\FileHandling\Files\Basics.txt";
        public string Categories = @"C:\Users\user\Desktop\FileHandling\Files\Categories.txt";
        public string Principals = @"C:\Users\user\Desktop\FileHandling\Files\Principals.txt";
        public string Roles = @"C:\Users\user\Desktop\FileHandling\Files\Roles.txt";
        public string Students = @"C:\Users\user\Desktop\FileHandling\Files\Students.txt";
        public string Teachers = @"C:\Users\user\Desktop\FileHandling\Files\Teachers.txt";
        public string Users = @"C:\Users\user\Desktop\FileHandling\Files\Users.txt";

        public void CreateAddressesFile()
        {
            if(!File.Exists(Addresses))
            {
                string fileName = "Addresses.txt";
                string asd = Path.Combine(path, fileName);
                File.Create(asd);
            }
        }

        public void CreateBasicsFile()
        {
            if (!File.Exists(Basics))
            {
                string fileName = "Basics.txt";
                string asd = Path.Combine(path, fileName);
                File.Create(asd);
            }
        }

        public void CreateCategoriesFile()
        {
            if (!File.Exists(Categories))
            {
                string fileName = "Categories.txt";
                string asd = Path.Combine(path, fileName);
                File.Create(asd);
            }
        }

        public void CreatePrincipalsFile()
        {
            if (!File.Exists(Principals))
            {
                string fileName = "Principals.txt";
                string asd = Path.Combine(path, fileName);
                File.Create(asd);
            }
        }

        public void CreateRolesFile()
        {
            if (!File.Exists(Roles))
            {
                string fileName = "Roles.txt";
                string asd = Path.Combine(path, fileName);
                File.Create(asd);
            }
        }

        public void CreateStudentsFile()
        {
            if (!File.Exists(Students))
            {
                string fileName = "Students.txt";
                string asd = Path.Combine(path, fileName);
                File.Create(asd);
            }
        }

        public void CreateTeachersFile()
        {
            if (!File.Exists(Teachers))
            {
                string fileName = "Teachers.txt";
                string asd = Path.Combine(path, fileName);
                File.Create(asd);
            }
        }

        public void CreateUsersFile()
        {
            if (!File.Exists(Users))
            {
                string fileName = "Users.txt";
                string asd = Path.Combine(path, fileName);
                File.Create(asd);
            }
        }

    }
}
