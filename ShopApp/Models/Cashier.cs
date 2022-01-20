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

        public static void printReceipt(List<IProduct> products,DateTime purchaseTime)
        {
            
            Console.WriteLine($"Date: {purchaseTime}");
            Console.WriteLine("Products:");
            double regularPrice = 0.0;
            double discountPrice = 0.0;
            foreach (var item in products)
            {
                if (item.GetType().Name == "Appliance")
                {
                    Appliance appliance = (Appliance)item;
                    
                    regularPrice += appliance.Price;
                    if (appliance.Price > 999 && IsWeekend(purchaseTime))
                    {
                        discountPrice += appliance.Price * 0.05;
                    }
                }
                else if(item.GetType().Name == "Clothes")
                {
                    Clothes clothes = (Clothes)item;
                    
                    regularPrice += clothes.Price;
                    if (!IsWeekend(purchaseTime))
                    {
                        discountPrice += clothes.Price * 0.10;
                    }
                }
                else
                {
                    PerishableProduct perishableProduct = (PerishableProduct)item;
                    regularPrice += perishableProduct.Price;
                    if((perishableProduct.ExpDate - purchaseTime).TotalDays == 0)
                    {
                        discountPrice += perishableProduct.Price * 0.50;
                        
                    }
                    else if((perishableProduct.ExpDate - purchaseTime).TotalDays < 5 && (perishableProduct.ExpDate - purchaseTime).TotalDays != 0)
                    {
                        discountPrice += perishableProduct.Price * 0.10;
                    }
                    
                    
                }
            }
            Console.WriteLine(discountPrice);
            Console.WriteLine(regularPrice);

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
    }
}
