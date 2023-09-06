using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Menu
{
    public class SuperAdmin
    {
        public void MainMenu()
        {
            Console.WriteLine(@"Press 1 to Staff Mgt\nPress 2 to Role Mgt");
            int opt = int.Parse(Console.ReadLine());
            if (opt == 1)
            {
                StaffMgt();
            }
            else if (opt == 2)
            {
                RoleMgt();
            }
            else
            {
                Console.WriteLine("wrong input");
            }
        }

        public void StaffMgt()
        {
            Console.WriteLine(@"Press 1 to Register Principal\nPress 2 to Register Teacher\nPress 3 to view principal details\nPress 4 to view all teachers\nPress 5 to view teacher's details\nPress 0 to go back to previous menu\npress # to go to main menu");
            int opt = int.Parse(Console.ReadLine());
            if (opt == 1)
            {

            }
            else if (opt == 2)
            {

            }
            else
            {
                Console.WriteLine("wrong input");
            }
        }

        public void RoleMgt()
        {
            Console.WriteLine(@"Press 1 to Create Role\nPress 2 to View Roles\nPress 0 to go back to previous menu\npress # to go to main menu");
            int opt = int.Parse(Console.ReadLine());
            if (opt == 1)
            {

            }
            else if (opt == 2)
            {

            }
            else
            {
                Console.WriteLine("wrong input");
            }
        }
    }
}
