using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Part_Pricing_Composite
{
    //inherits from Items to ba able to use properties
    //overrides the inherited calculate method
    public class Leaf : Items, IComponent
    {
        public Leaf(string name, int price, int quantity) : base(name, price, quantity) { }


        public int CalculateTotalPrice()
        {
            Console.WriteLine(name + " with the price " + (price * quantity));
            return (price * quantity);
        }


    }
}
