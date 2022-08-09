using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class GroundCoffee
    {
        public int Quantity { get; private set; }

        public GroundCoffee(int quantity)
        {
            Quantity = quantity;
        }
    }
}
