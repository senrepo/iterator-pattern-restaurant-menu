using System;

namespace composite_pattern_restaurant_menu
{
    class Program
    {
        static void Main(string[] args)
        {

            //Composite patters -> Compose objects in tree structure, in this way treat Menu (Composite elements) and Menu Items (leaf elements) in a same structure.
            
            MenuComponent allMenu = new Menu("Master Menu", "All Menus Combained..");
            MenuComponent panCakeHouseMenu = new Menu("PanCake House Menu", "Breakfast Items..");
            MenuComponent objectVilleMenu = new Menu("ObjectVille Menu", "Lunch and Dinner Items..");

            allMenu.Add(panCakeHouseMenu);
            allMenu.Add(objectVilleMenu);

            panCakeHouseMenu.Add(new MenuItem("K&B Pancake Breakfast", "Pancake with scrambled eggs and toased", true, 2.99));
            panCakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast", "Pancake with fried eggs and sausage", false, 2.99));
            panCakeHouseMenu.Add(new MenuItem("Blueberry Pancake Breakfast", "Pancake made with fresh blueberries", true, 3.49));

            objectVilleMenu.Add(new MenuItem("Vegetarian BLT", "Lattue and tomoto on a whole wheet", true, 2.99));
            objectVilleMenu.Add(new MenuItem("Soup of the day", "Soup of the day with side of potato salad", false, 2.75));
            objectVilleMenu.Add(new MenuItem("Hotdog", "Hotdog with fresh vegetables, topped with cheese", true, 3.29));
            
            MenuComponent icecreamMenu = new Menu("Icecrem Menu", "All Icecreams");
            icecreamMenu.Add(new MenuItem("Vannila", "Vannila Icecream", true, 1.99));
            icecreamMenu.Add(new MenuItem("Chocklate", "Chocklate Icecream", true, 2.99));
            objectVilleMenu.Add(icecreamMenu);


            Waitress waitress = new Waitress(allMenu);
            waitress.PrintMenu();

            Console.WriteLine("");
            Console.WriteLine("Press any key to exit..");
            Console.ReadLine();

        }
    }
}
