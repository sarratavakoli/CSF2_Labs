using Block3LabLibrary;
using System.Collections;

namespace Block3Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region typed list with 6 Product objects
            List<Product> products = new List<Product>();
            products.Add(new Product(111, "Tales of Arise: Deluxe Edition", 10101, "Action JRPG", 84.99m));
            products.Add(new Product(222, "Legend of Mana", 20202, "Vintage Realtime Tactics RPG", 29.99m));
            products.Add(new Product(333, "Gris", 30303, "Atmospheric 2D Indie Game", 16.99m));
            products.Add(new Product(444, "Graveyard Keeper", 40404, "Indie Resource Management Game", 19.99m));
            products.Add(new Product(555, "Monster Hunter Rise", 50505, "Action RPG", 59.99m));
            products.Add(new Product(666, "FINAL FANTASY XIV Online - Complete Edition", 60606, "One of the most popular MMORPGs of all time", 59.98m));
            #endregion

            Console.WriteLine("\n\nTYPED LIST\n\n");

            //print typed list
            foreach (Product product in products)
            {
                Console.WriteLine("-+*+-+*+-+*+-+*+-+*+");
                Console.WriteLine(product);
            }

            //dictionary
            Dictionary<int, Product> products2 = new Dictionary<int, Product>()
            {
                { products[0].ID, products[0] },
                { products[1].ID, products[1] },
                { products[2].ID, products[2] },
                { products[3].ID, products[3] },
                { products[4].ID, products[4] },
                { products[5].ID, products[5] }
            };

            Console.WriteLine("\n\nDICTIONARY\n\n");

            //iterate through the Dictionary and print out each object to the screen.
            foreach (var kvp in products2)
            {
                Console.WriteLine("-+*+-+*+-+*+-+*+-+*+");
                Console.WriteLine(kvp.Value);
            }

            Console.WriteLine("\n\n");
        }


    }
}