using System;


namespace BuchhaltungConsolenApp
{
    abstract class Menu
    {
        public Menu()
        {
            Console.Clear();
            DisplayMenu();
        }
        public abstract void DisplayMenu();
    }
}
