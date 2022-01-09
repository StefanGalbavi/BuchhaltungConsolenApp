using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuchhaltungConsolenApp
{
    internal class StartMenu : Menu
    {
        public override void DisplayMenu()
        {
            Console.WriteLine("Willkomen zur Buchhaltungs-Software!");
            Console.WriteLine();
            Console.WriteLine("Was möchtest du tun?");
            Console.WriteLine("--------------------");
            Console.WriteLine("[1] Neues Profil erstellen");
            Console.WriteLine("[2] Profil laden");
            Console.WriteLine();

            InputOption();
        }

        private void InputOption()
        {
            string input;
            Menu nextMenu;

            while (true)
            {
                Console.Write("Eingabe: ");
                input = Console.ReadLine();

                bool correctInput = true;

                switch (input)
                {
                    case "1":
                        nextMenu = new CreateProfileMenu();
                        break;

                    case "2":
                        nextMenu = new LoadProfileMenu();
                        break;

                    default:
                        correctInput = false;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ungültige Eingabe!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

                if (correctInput)
                {
                    break;
                }
            }
        }
    }
}
