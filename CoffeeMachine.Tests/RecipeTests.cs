using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Tests
{
    public class RecipeTests
    {
        [Fact]
        public void CreateRecipe_Set_Success()
        {
            //Arrange + Act
            Recipe recipe = new Recipe(0, 100, 20, "name");

            //Assert
            Assert.Equal(0, recipe.Beans);
            Assert.Equal(100, recipe.Water);
            Assert.Equal(20, recipe.Milk);
            
        }
    }
}
