using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Part_Pricing_Composite
{
    //two protected fields and one abstract method. These fields and method are
    //going to be used as an interface between the Leaf and the Composite part of our pattern.


    public abstract class Items
    {
        protected string name;
        protected int price;
        protected int quantity;

        public Items(string name, int price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
