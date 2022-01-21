using ShopApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public static class Cashier
    {

        public static Dictionary<IProduct,int> calculateProducts(List<IProduct> products)
        {

            Dictionary<IProduct, int> productCount = new Dictionary<IProduct, int>();
            foreach (var item in products)
            {
                if (item.GetType().Name == "Appliance")
                {
                    Appliance appliance = (Appliance)item;

                    if (!productCount.ContainsKey(appliance))
                    {
                        productCount.Add(appliance, 0);
                    }
                    productCount[appliance]++;

                }
                else if(item.GetType().Name == "Clothes")
                {
                    Clothes clothes = (Clothes)item;

                    if (!productCount.ContainsKey(clothes))
                    {
                        productCount.Add(clothes, 0);
                    }
                    productCount[clothes]++;

                }
                else if(item.GetType().Name == "Food")
                {
                    Food food = (Food)item;

                    if (!productCount.ContainsKey(food))
                    {
                        productCount.Add(food, 0);
                    }
                    productCount[food]++;
                    
                }
                else
                {
                    Beverage beverage = (Beverage)item;

                    if (!productCount.ContainsKey(beverage))
                    {
                        productCount.Add(beverage, 0);
                    }
                    productCount[beverage]++;
                }
            }
            return productCount;

        }
        private static bool IsWeekend(DateTime time)
        {
            if(time.DayOfWeek == DayOfWeek.Sunday || time.DayOfWeek == DayOfWeek.Saturday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static double CalculateDiscount(IProduct product,DateTime purchaseTime)
        {
            double discountPrice = 0.0;

            if (product.GetType().Name == "Appliance")
            {
                Appliance appliance = (Appliance)product;

                if (appliance.Price > 999 && IsWeekend(purchaseTime))
                {
                    discountPrice = appliance.Price * 0.05;
                }
            }
            else if (product.GetType().Name == "Clothes")
            {
                Clothes clothes = (Clothes)product;
                if (!IsWeekend(purchaseTime))
                {
                    discountPrice = clothes.Price * 0.10;
                }
            }
            else if (product.GetType().Name == "Food")
            {
                Food food = (Food)product;

                if ((food.ExpDate - purchaseTime).TotalDays == 0)
                {
                    discountPrice = food.Price * 0.50;

                }
                else if ((food.ExpDate - purchaseTime).TotalDays < 5 && (food.ExpDate - purchaseTime).TotalDays != 0)
                {
                    discountPrice = food.Price * 0.10;
                }
            }
            else
            {
                Beverage beverage = (Beverage)product;

                if ((beverage.ExpDate - purchaseTime).TotalDays == 0)
                {
                    discountPrice = beverage.Price * 0.50;

                }
                else if ((beverage.ExpDate - purchaseTime).TotalDays < 5 && (beverage.ExpDate - purchaseTime).TotalDays != 0)
                {
                    discountPrice = beverage.Price * 0.10;
                }
            }
            return discountPrice;
        }
        public  static void printResult(List<IProduct> products,DateTime purshaseDateTime)
        {
            Console.WriteLine("............Products...........");
            Dictionary<IProduct, int> productCount = calculateProducts(products);
            foreach (var item in productCount)
            {
                Console.WriteLine($"{item.Key.Name} - {item.Key.Brand}");
                Console.WriteLine($"{item.Value} x {item.Key.Price} = {item.Value * item.Key.Price}");
                double discount = CalculateDiscount(item.Key, purshaseDateTime);
                if (discount != 0)
                {
                    Console.WriteLine($"#discount -${discount * item.Value}");
                }
            }
        }
    }
}
