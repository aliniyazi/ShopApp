using ShopApp.Interfaces;
using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Food food = new Food(new DateTime(2021, 06, 14), "apples", "brandA", 3.68);
            Beverage beverage = new Beverage(new DateTime(2022,02,02), "milk", "brandM", 0.99);
            Clothes clothes = new Clothes(Enums.DressSize.M, Color.Violet, "T-shirt", "brandM", 15.99);
            Appliance appliance = new Appliance("modelL", new DateTime(2021, 03, 03), 1.125, "laptop", "brandL", 2345);
            List<IProduct> products = new List<IProduct>();
            products.Add(beverage);
            products.Add(beverage);
            products.Add(beverage);
            products.Add(clothes);
            products.Add(clothes);
            products.Add(appliance);
            products.Add(food);
            Cashier.printReceipt(products, new DateTime(2021, 06, 14));


        }
    }
}
