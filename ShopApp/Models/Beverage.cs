using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class Beverage : PerishableProduct
    {
        public Beverage(DateTime expdate, string name, string brand, double price) : base(expdate, name, brand, price)
        {

        }
    }
}
