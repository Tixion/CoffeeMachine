namespace CoffeeMachine.Tests
{
    public class ContainerTests
    {
        [Fact]
        public void CreateContainer_NormalCapacity_Success()
        {
            //Arrange
            const int expectedCapacity = 1000;
            var container = new Container(expectedCapacity);

            //Act
            var actualCapacity = container.Capacity;

            //Assert
            Assert.Equal(expectedCapacity, actualCapacity);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(3001)]
        public void CreateContainer_InvalidCapacity_Throws(int capacity)
        {
            //Arrange + Act + Assert
            Assert.Throws<ArgumentException>(() => new Container(capacity));
        }

        [Fact]
        public void GetResource_NormalCapacity_IncreasedCapacity()
        {
            //Arrange
            const int startingCapacity = 1000;
            const int extractedCapacity = 400;
            const int expectedCapacity = startingCapacity - extractedCapacity;
            var container = new Container(startingCapacity);

            //Act
            container.ExtractResource(extractedCapacity);
            var actualCapacity = container.Capacity;

            //Assert
            Assert.Equal(expectedCapacity, actualCapacity);
        }

        [Fact]
        public void LoadResource_NormalCapacity_DecreasedCapacity()
        {
            //Arrange
            const int startingCapacity = 1000;
            const int addedCapacity = 400;
            const int expectedCapacity = startingCapacity + addedCapacity;
            var container = new Container(startingCapacity);

            //Act
            container.LoadResource(addedCapacity);
            var actualCapacity = container.Capacity;

            //Assert
            Assert.Equal(expectedCapacity, actualCapacity);
        }

        [Fact]
        public void GetResource_UnderCurrentCapacity_Throws()
        {
            //Arrange
            const int startingCapacity = 100;
            const int extractedCapacity = 101;
            var container = new Container(startingCapacity);

            //Act + Assert
            Assert.Throws<InvalidOperationException>(() => container.ExtractResource(extractedCapacity));
        }

        [Fact]
        public void LoadResource_OverMaximumCapacity_Throws()
        {
            //Arrange
            const int startingCapacity = 3000;
            const int addedCapacity = 1;
            var container = new Container(startingCapacity);

            //Act + Assert
            Assert.Throws<InvalidOperationException>(() => container.LoadResource(addedCapacity));
        }
    }
}