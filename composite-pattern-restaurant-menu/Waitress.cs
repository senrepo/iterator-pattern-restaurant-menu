using System;
using System.Collections.Generic;
using System.Text;

namespace composite_pattern_restaurant_menu
{
    public class Waitress
    {
        MenuComponent allMenu;

        public Waitress(MenuComponent allMenu)
        {
            this.allMenu = allMenu;
        }
        
        public void PrintMenu()
        {
            allMenu.Print();
        }
    }
}
