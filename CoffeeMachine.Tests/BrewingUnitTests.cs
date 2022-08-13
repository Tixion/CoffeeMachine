using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Tests
{
    public class BrewingUnitTests
    {
        [Fact]
        public void Brew_GroundCoffee_Coffee()
        {
            //Arrange
            BrewingUnit brewer = new BrewingUnit();
            GroundCoffee groundCoffee = new GroundCoffee(100);
            Recipe recipe = new Recipe(100, 200, 0, "name");
            Coffee expectedCoffee = new Coffee(recipe);

            //Act
            Coffee actualCoffee = brewer.Brew(groundCoffee, recipe);

            //Assert
            Assert.Equal(expectedCoffee.recipe, actualCoffee.recipe);
        }
    }
}
