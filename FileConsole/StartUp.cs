using FileHandling.FileContext;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    public class StartUp
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        FileAppContext app = new FileAppContext();
        public void Start()
        {
            string path = @"C:\Users\user\Desktop\FileHandling\Files";
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            ConfigureLogging();

            app.CreateAddressesFile();
            app.CreateBasicsFile();
            app.CreateCategoriesFile();
            app.CreatePrincipalsFile();
            app.CreateRolesFile();
            app.CreateStudentsFile();
            app.CreateTeachersFile();
            app.CreateUsersFile();
        }

        private static void ConfigureLogging()
        {
            string path = @"C:\Users\user\Desktop\FileHandling\NLog.config";
            LogManager.Setup().LoadConfigurationFromFile(path);
        }
    }
}
