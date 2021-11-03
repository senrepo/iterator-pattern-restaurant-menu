using System;
using System.Collections.Generic;
using System.Text;

namespace iterator_on_different_collections
{
    public class MenuItem
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

        public string GetName()
        {
            return name;
        }
        public string GetDescription()
        {
            return description;
        }
        public bool IsVegetaraian()
        {
            return isVegetaraian;
        }
        public double GetPrice()
        {
            return price;
        }

    }
}
