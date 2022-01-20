using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Interfaces
{
    public interface IProduct
    {
        string Name { get; set; }
        string Brand { get; set; }
        double Price { get; set; }
    }
}
