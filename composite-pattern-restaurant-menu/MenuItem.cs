using System;
using System.Collections.Generic;
using System.Text;

namespace composite_pattern_restaurant_menu
{
    public class MenuItem : MenuComponent
    {
        private string name;
        private string description;
        private bool isVegetaraian;
        private double price;

        public MenuItem(string name, string desription, bool isVegetarian, double price)
        {
            this.name = name;
            this.description = desription;
            this.isVegetaraian = isVegetarian;
            this.price = price;
        }

        public override string GetName()
        {
            return name;
        }
        public override string GetDescription()
        {
            return description;
        }
        public override bool IsVegetarian()
        {
            return isVegetaraian;
        }
        public override double GetPrice()
        {
            return price;
        }

        public override void Print()
        {
            string veg = IsVegetarian() ? "(v)" : string.Empty;
            Console.WriteLine($" {GetName()} {veg} - {GetPrice()} -- {GetDescription()}");
        }

    }
}
