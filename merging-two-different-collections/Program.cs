using System;

namespace merging_two_different_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Waitress waitress = new Waitress();
            waitress.PrintMenu();

            Console.WriteLine("");
            Console.WriteLine("Press any key to exit..");
            Console.ReadLine();
            
        }
    }
}
