using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Coffee
    {
        public Recipe recipe { get; private set; }

        public Coffee(Recipe recipe)
        {
            this.recipe = recipe;
        }

        public bool Equals(Coffee coffee)
        {
            return this.recipe.Equals(coffee.recipe);
        }
    }
}
