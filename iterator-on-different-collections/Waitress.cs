using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace iterator_on_different_collections
{
    public class Waitress
    {
        List<IMenu> menus = null;

        public Waitress(List<IMenu> menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            foreach(var menu in menus)
            {
                var enumerator = menu.GetEnumerator();

                while(enumerator.MoveNext())
                {
                    var item = (MenuItem) enumerator.Current;
                    PrintMenuItem(item);
                }
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
