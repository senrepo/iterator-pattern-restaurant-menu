using System;
using System.Collections.Generic;

namespace iterator_on_different_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMenu> menus = new List<IMenu>()
            {
                new PanCakeHouseMenu(),
                new ObjectVilleDinnerMenu()
            };

            Waitress waitress = new Waitress(menus);
            waitress.PrintMenu();

            Console.WriteLine("");
            Console.WriteLine("Press any key to exit..");
            Console.ReadLine();
        }
    }
}
