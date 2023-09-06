using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Menu
{
    public class Teacher
    {
        public void MainMenu()
        {
            Console.WriteLine(@"Press 1 to Register\nPress 2 to Login");
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
