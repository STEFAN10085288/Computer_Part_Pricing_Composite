using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Part_Pricing_Composite
{
    //Add and remove methods. Not in the abstract class because Leal class will not be using them
    //Only composite class will use these methods
    public interface IComponent
    {
       int CalculateTotalPrice();
        
    }
}
