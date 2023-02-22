using System;

namespace OnlineShop
{
    class program
    {

    
        static void Main(string[] args)
        {
            Welcome();
            PurchaseItem();

        }

        static void Welcome()
        {
            Console.WriteLine("Welcome to our shop, ");
            Console.WriteLine("make your choice");
            Console.WriteLine("cloths");
            Console.WriteLine("Games");
            Console.WriteLine("Computers");
            Console.WriteLine("Funitures");
            Console.WriteLine("FoodItems");
            Console.WriteLine("Make your choice");
        }
        static void PurchaseItem()
        {
               var item = Console.ReadLine();



            switch (item)
            {
                case "Cloths":
                    var cloths = new Cloths();
                    cloths.Designer = "#SMG Fashion house";
                    cloths.Title = "Flowing Gown";
                    cloths.Price = 19.9;
                    Console.WriteLine($"You purchased a {cloths.Title} {cloths.Designer} for the price of{cloths.Price}");
                    break;

                case "Games":
                    var  Games = new Games();
                    Games.Version = "PS4:4.0";
                    Games.Title = "Playstation4";
                    Games.Price = 110.99;
                    Console.WriteLine($"You purchased a {Games.Title} {Games.Version} for the price of {Games.Price}");
                    break;

                case "Computers":
                    var Computers = new Computers();
                    Computers.Manufactural = "HP";
                    Computers.Title = "LapTop";
                    Computers.Price = 200.2;
                    Console.WriteLine($"You purchased a {Computers.Title} {Computers.Manufactural} for for the price of{Computers.Price}");
                    break;

                case "Funitures":
                    var Funitures = new Funitures();
                    Funitures.MaterialType = "Leather";
                    Funitures.Title = "couch";
                    Funitures.Price = 150.11;
                    Console.WriteLine($"You purchased a {Funitures.Title} {Funitures.MaterialType} for the price of{Funitures.Price}");
                    break;
                
                case "FoodItems":
                    var FoodItems = new FoodItems();
                    FoodItems.Categories = "fruits";
                    FoodItems.Title = "banana";
                    FoodItems.Price = 5.99;
                    Console.WriteLine($"You purchased a {FoodItems.Title} {FoodItems.Categories} for the price of{FoodItems.Price}");
                    break;

                default:
                    break;
                
                             
            }
        }

    }

    class BaseItem
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }

    class Cloths : BaseItem
    {
        public string Designer { get; set; }
    }
    class  Games : BaseItem
    {
        public string Version { get; set; }
    }
    class Computers : BaseItem
    {
        public string Manufactural { get; set; }
    }
    class Funitures : BaseItem
    {
        public string MaterialType { get; set; }
    }
    class FoodItems : BaseItem
    {
        public string Categories { get; set; }
    }
}