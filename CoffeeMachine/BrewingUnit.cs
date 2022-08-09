using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class BrewingUnit
    {
        public Coffee Brew(GroundCoffee groundCoffee, Recipe recipe) 
        {
            if (groundCoffee.Quantity == recipe.Beans)
                return new Coffee(recipe);
            else throw new InvalidOperationException();
        }
    }
}
