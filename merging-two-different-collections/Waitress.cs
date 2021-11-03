using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace merging_two_different_collections
{
    public class Waitress
    {
        public void PrintMenu()
        {
            PanCakeHouseMenu pancakeHouseMenu = new PanCakeHouseMenu();
            ArrayList panCakeHouseMenuItems = pancakeHouseMenu.GetMenuItems();

            ObjectVilleDinnerMenu objectVilleDinnerMenu = new ObjectVilleDinnerMenu();
            MenuItem[] objectVilleDinnerMenuItems = objectVilleDinnerMenu.GetMenuItems();


           /* The for each logic differs based on the collection object used.
            * Here, ArrayList used, so Count method used
            * Hence for any new merger, then this method logic needs updated to cover the new collection.
            * So this is not a efficient way
            */
           for(int i=0; i<panCakeHouseMenuItems.Count; i++)
           {
                MenuItem item = (MenuItem)panCakeHouseMenuItems[i];
                PrintMenuItem(item);
           }


            /* The for each logic differs based on the collection object used.
             * Here, Array used, so Lenght method used
             * 
             */

            for (int i = 0; i < objectVilleDinnerMenuItems.Length; i++)
            {
                MenuItem item = (MenuItem)objectVilleDinnerMenuItems[i];
                PrintMenuItem(item);
            }


        }

        private void PrintMenuItem(MenuItem item)
        {
            Console.WriteLine($"{item.GetName()} - {item.GetDescription()} - {item.GetPrice() }");
        }

        public void PrintVegMenu()
        {

        }

        public void IsVegItem(string item)
        {

        }
    }
}
