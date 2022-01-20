using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public abstract class PerishableProduct : Product
    {
        public DateTime ExpDate { get; set; }
        public PerishableProduct(DateTime expdate,string name,string brand,double price) : base(name,brand,price)
        {
            this.ExpDate = expdate;
        }
    }
}
