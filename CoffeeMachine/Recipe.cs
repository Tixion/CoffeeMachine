using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Recipe
    {
        public int Beans { get; private set; }
        public int Water { get; private set; }
        public int Milk { get; private set; }

        public Recipe(int beans, int water, int milk)
        {
            Beans = beans;
            Water = water;
            Milk = milk;
        }

        public bool Equals(Recipe recipe)
        {
            return this.Beans == recipe.Beans && this.Water == recipe.Water && this.Milk == recipe.Milk;
        }
    }
}
