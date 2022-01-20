using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class Appliance : Product
    {
        public Appliance(string model,DateTime productiontime,double weight, string name,string brand,double price) : base(name,brand,price)
        {
            this.Model = model;
            this.ProductionDate = productiontime;
            this.Weight = weight;
        }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public double Weight { get; set; }
    }
}
