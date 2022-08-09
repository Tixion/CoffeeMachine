using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public enum RecipeName
    {
        Espresso,
        Filtered,
        Cappuccino
    }

    public class CoffeeMachine
    {
        public Dictionary<RecipeName, Recipe> _recipes = new Dictionary<RecipeName, Recipe>()
        {
            { RecipeName.Espresso, new Recipe(100, 200, 0) },
            { RecipeName.Filtered, new Recipe(12, 200, 0) },
            { RecipeName.Cappuccino, new Recipe(100, 200, 150) }
        };

        GrinderUnit _grinderUnit = new GrinderUnit();

        BrewingUnit _brewingUnit = new BrewingUnit();

        Container _beansContainer = new Container(Container.MaxCapacity);

        Container _waterContainer = new Container(Container.MaxCapacity);

        Container _milkContainer = new Container(Container.MaxCapacity);

        public Coffee Brew(Recipe recipeName)
        {
            _beansContainer.ExtractResource(recipeName.Beans);
            _waterContainer.ExtractResource(recipeName.Water);
            _milkContainer.ExtractResource(recipeName.Milk);

            return _brewingUnit.Brew(_grinderUnit.Grind(recipeName.Beans), recipeName);
        }

        public void LoadBeans(int value)
        {
            _beansContainer.LoadResource(value);
        }

        public void LoadWater(int value)
        {
            _waterContainer.LoadResource(value);
        }

        public void LoadMilk(int value)
        {
            _milkContainer.LoadResource(value);
        }

        public int getBeansLevel()
        {
            return _beansContainer.Capacity;
        }

        public int getWaterLevel()
        {
            return _waterContainer.Capacity;
        }

        public int getMilkLevel()
        {
            return _milkContainer.Capacity;
        }
    }
}
