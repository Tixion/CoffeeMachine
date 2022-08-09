using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Tests
{
    public class GroundCoffeeTests
    {
        [Fact]
        public void CreateGroundCoffee_GiveBeans_GivenQuantity()
        {
            //Arrange + Act 
            GroundCoffee groundCoffee = new GroundCoffee(100);

            //Assert
            Assert.Equal(100, groundCoffee.Quantity);
        }
    }
}
