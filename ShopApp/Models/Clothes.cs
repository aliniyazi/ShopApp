using ShopApp.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class Clothes : Product
    {
        public DressSize Size { get; set; }
        public Color Color { get; set; }
        public Clothes(DressSize dresssize ,Color color, string name,string brand,double price) : base(name,brand,price)
        {
            this.Size = dresssize;
            this.Color = color;
        }
    }
}
