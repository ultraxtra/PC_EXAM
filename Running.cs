using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configurator;
using static System.Console;
using System.IO;
using System.Xml;

namespace Configurator
{
    internal class Running
    {
        private Menu menu;
        public Running()
        {
            menu = new Menu();
        }
        public void Run()
        {
            PC pC = new PC();
            this.menu.FillMenu(pC);
            int choice = 0;
            while (true)
            {
                Console.Clear();
                this.menu.PrintMenu();
                Write("Choice a item of menu: ");
                choice = Convert.ToInt32(ReadLine());
                if (choice == 0)
                {
                    WriteLine("GoodBye!");
                    return;
                }

                else if(choice == 1)
                {
                    pC.CreatePC();
                    
                    
                }

                else if (choice == 2)
                {
                    pC.PCs();
                    WriteLine("Press 1 to go back to the menu");
                    int choise = Convert.ToInt32(ReadLine());
                    if (choise == 1)
                    {
                        this.menu.PrintMenu();
                    }
                }

                else if(choice == 3)
                {
                    pC.Order();
                    WriteLine("Press 1 to go back to the menu");
                    int choise = Convert.ToInt32(ReadLine());
                    if(choise == 1)
                    {
                        this.menu.PrintMenu();
                    }
                }

                else if(choice == 4)
                {
                    pC.Components();
                    WriteLine("Press 1 to go back to menu");
                    WriteLine("Press 0 to exit");
                    int choise;
                    choise = Convert.ToInt32(ReadLine());
                    if (choise == 0)
                    {
                        WriteLine("Good Bye!");
                        return;
                    }

                    else if (choise == 1)
                    {
                        this.menu.PrintMenu();
                    }
                }
                else
                {
                    throw new KeyNotFoundException("Uncorrect Value");
                }
                Thread.Sleep(4000);
            }
        }
    }
}
