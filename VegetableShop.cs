using System;
using System.Collections.Generic;

public class VegetableShop
{
    private List<Vegetable> products = new List<Vegetable>();

    public void AddProduct(Vegetable vegetable)
    {
        products.Add(vegetable);
        Console.WriteLine($"{vegetable.Name} added to the shop");
    }

    public void AddProducts(List<Vegetable> initialProducts)
    {
        products.AddRange(initialProducts);
    }

    public void DisplayProducts()
    {
        Console.WriteLine("Product list");
        decimal total = 0;

        foreach (var veg in products)
        {
            Console.WriteLine(veg.GetInfo());
            total += veg.GetPrice();
        }

        Console.WriteLine($"Total price: {total:C}");
    }
}