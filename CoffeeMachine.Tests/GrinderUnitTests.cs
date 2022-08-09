using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Tests
{
    public class GrinderUnitTests
    {
        [Fact]
        public void Grind_Recipe_RecipeAmountOfGroundCoffee()
        {
            //Arrange
            GroundCoffee espressoGroundCoffee = new GroundCoffee(100);
            var grinder = new GrinderUnit();

            //Act + Assert
            Assert.Equal(grinder.Grind(100).Quantity, espressoGroundCoffee.Quantity);
        }
    }
}
