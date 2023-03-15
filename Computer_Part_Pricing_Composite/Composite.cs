using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Part_Pricing_Composite
{
    //list to store leaf and composite objects
    //able to remove and add items
    //can calculate total price for all the items
    public class Composite : Items,IComponent
    {

        private List<Items> components;

        public Composite(string name, int price, int quantity) : base(name, price, quantity)
        {
            components = new List<Items>();
        }

        public void AddItem(Items item)
        {
            components.Add(item);
        }

        public void RemoveItem(Items item)
        {
            components.Remove(item);
        }
        public int CalculateTotalPrice()
        {
            int miniTotal = (price * quantity);
            int total = 0;
            Console.WriteLine(name + " contains the following with prices: " + miniTotal);
            foreach (IComponent item in components)
            {
                total += item.CalculateTotalPrice();
            }
            return total + miniTotal;
        }
    }
}
