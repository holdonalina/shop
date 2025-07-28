using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var initialProducts = new List<Vegetable>()
        {
            new PieceVegetable("Carrot", 15, 1),
            new KiloVegetable("Potato", 20, 4),
            new KiloVegetable("Cucumber", 14, 2),
            new PieceVegetable("Tomato", 4, 6)
        };

        VegetableShop shop = new VegetableShop();
        shop.AddProducts(initialProducts);
        shop.DisplayProducts();

        string choice;
        do
        {
            Console.WriteLine("Vegetable sHoP");
            Console.WriteLine("1: Add new product");
            Console.WriteLine("2: Show all products");
            Console.WriteLine("3: Exit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddNewProduct(shop);
                    break;
                case "2":
                    shop.DisplayProducts();
                    break;
                case "3":
                    Console.WriteLine("Byeeeeee");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        } while (choice != "3");
    }

    static void AddNewProduct(VegetableShop shop)
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter base price: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal basePrice) || basePrice <= 0)
        {
            Console.WriteLine("Invalid price");
            return;
        }

        Console.Write("Is this product sold by kg (yes or no)? ");
        string unit = Console.ReadLine().ToLower();

        if (unit == "yes")
        {
            Console.Write("Enter number of kilograms: ");
            if (double.TryParse(Console.ReadLine(), out double kg) && kg > 0)
            {
                shop.AddProduct(new KiloVegetable(name, basePrice, kg));
            }
            else
            {
                Console.WriteLine("Invalid quantity");
            }
        }
        else
        {
            Console.Write("Enter number of pieces: ");
            if (int.TryParse(Console.ReadLine(), out int pieces) && pieces > 0)
            {
                shop.AddProduct(new PieceVegetable(name, basePrice, pieces));
            }
            else
            {
                Console.WriteLine("Invalid quantity");
            }
        }
    }
}