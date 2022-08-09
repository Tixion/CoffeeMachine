using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Tests
{
    public class CoffeeTests
    {
        [Fact]
        public void CreateCoffee_GiveRecipe_GivenRecipe()
        {
            //Arrange
            Recipe recipe = new Recipe(100, 200, 0);

            //Act
            var coffee = new Coffee(recipe);

            //Assert
            Assert.Equal(recipe, coffee.recipe);
        }
    }
}
