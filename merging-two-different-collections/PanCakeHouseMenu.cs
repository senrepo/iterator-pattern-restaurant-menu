using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace merging_two_different_collections
{
    public class PanCakeHouseMenu
    {
        ArrayList menuItems;

        public PanCakeHouseMenu()
        {
            menuItems = new ArrayList();

            AddItem("K&B Pancake Breakfast", "Pancake with scrambled eggs and toased", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancake with fried eggs and sausage", false, 2.99);
            AddItem("Blueberry Pancake Breakfast", "Pancake made with fresh blueberries", true, 3.49);
        }

        public void AddItem(string name, string desription, bool isVegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, desription, isVegetarian, price);
            menuItems.Add(menuItem);
        }

        public ArrayList GetMenuItems()
        {
            return menuItems;
        }
    }
}
