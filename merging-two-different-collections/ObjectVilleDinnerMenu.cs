using System;
using System.Collections.Generic;
using System.Text;

namespace merging_two_different_collections
{
    public class ObjectVilleDinnerMenu
    {
        const int MAX_ITEMS = 3;
        private int itemsCount = 0;
        private MenuItem[] menuItems;

        public ObjectVilleDinnerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT", "Lattue and tomoto on a whole wheet", true, 2.99);
            AddItem("Soup of the day", "Soup of the day with side of potato salad", false, 2.75);
            AddItem("Hotdog", "Hotdog with fresh vegetables, topped with cheese", true, 3.29);
        }

        public void AddItem(string name, string desription, bool isVegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, desription, isVegetarian, price);
            if(itemsCount < MAX_ITEMS)
            {
                menuItems[itemsCount] = menuItem;
                itemsCount++;
            }
            else
            {
                throw new InvalidOperationException("Sorry, Menu is full, can't add a new menu item");
            }
            
        }

        public MenuItem[] GetMenuItems()
        {
            return menuItems;
        }

    }
}
