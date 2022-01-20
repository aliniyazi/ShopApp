using ShopApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public abstract class Product : IProduct
    {
        public Product(string name,string brand,double price)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
        }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
    }
}
