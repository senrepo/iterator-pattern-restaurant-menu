using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace composite_pattern_restaurant_menu
{
    public class Menu : MenuComponent
    {
        private List<MenuComponent> menuComponents = new List<MenuComponent>();
        private string name;
        private string description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override string GetName()
        {
            return name;
        }

        public override string GetDescription()
        {
            return name;
        }

        public override void Print()
        {
            Console.WriteLine($" {GetName()} -- {GetDescription()}");

            var enumerator = menuComponents.GetEnumerator();

            while(enumerator.MoveNext()) 
            {
                MenuComponent component = enumerator.Current;
                component.Print();
            }
        }

    }
}
