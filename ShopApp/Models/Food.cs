using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class Food : PerishableProduct
    {
        public Food(DateTime expdate, string name, string brand, double price) : base(expdate, name, brand, price)
        {
            
        }
    }
}
