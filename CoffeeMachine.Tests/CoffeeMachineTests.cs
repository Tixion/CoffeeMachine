using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Tests
{
    public class CoffeeMachineTests
    {
        [Fact]
        public void MakeCoffee_Cappuccino()
        {
            //Arrange
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            Recipe cappucinoRecipe = new Recipe(100, 200, 150);
            Coffee expectedCoffee = new Coffee(cappucinoRecipe);

            //Act
            Coffee actualCoffee = coffeeMachine.Brew(coffeeMachine._recipes[RecipeName.Cappuccino]);

            //Assert
            Assert.True(expectedCoffee.Equals(actualCoffee));
        }

        [Fact]
        public void ShowContainersLevel_AfterOneEspresso_CorrectCapacity()
        {
            //Arrange
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            Recipe espressoRecipe = new Recipe(100, 200, 0);

            //Act 
            coffeeMachine.Brew(coffeeMachine._recipes[RecipeName.Espresso]);

            //Assert
            Assert.Equal(coffeeMachine.getBeansLevel(), Container.MaxCapacity - espressoRecipe.Beans);
            Assert.Equal(coffeeMachine.getWaterLevel(), Container.MaxCapacity - espressoRecipe.Water);
            Assert.Equal(coffeeMachine.getMilkLevel(), Container.MaxCapacity - espressoRecipe.Milk);
        }

        [Fact]
        public void RefillContainers_AfterOneEspresso_MaximumCapacityContainers()
        {
            //Arrange
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            Recipe espressoRecipe = new Recipe(100, 200, 0);
            coffeeMachine.Brew(coffeeMachine._recipes[RecipeName.Espresso]);

            //Act 
            coffeeMachine.LoadBeans(espressoRecipe.Beans);
            coffeeMachine.LoadWater(espressoRecipe.Water);
            coffeeMachine.LoadMilk(espressoRecipe.Milk);

            //Assert
            Assert.Equal(coffeeMachine.getBeansLevel(), Container.MaxCapacity);
            Assert.Equal(coffeeMachine.getWaterLevel(), Container.MaxCapacity);
            Assert.Equal(coffeeMachine.getMilkLevel(), Container.MaxCapacity);
        }
    }
}
