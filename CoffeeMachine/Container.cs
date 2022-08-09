namespace CoffeeMachine
{
    public class Container
    {
        public const int MaxCapacity = 3000;

        public int Capacity { get; private set; }

        public Container(int capacity)
        {
            if (capacity <= 0 || capacity > MaxCapacity) throw new ArgumentException();

            Capacity = capacity;
        }   

        public int ExtractResource(int extractedCapacity)
        {
            this.Capacity -= extractedCapacity;

            if (this.Capacity < extractedCapacity) throw new InvalidOperationException();

            return extractedCapacity;
        }

        public void LoadResource(int addedCapacity)
        {
            if (this.Capacity + addedCapacity > MaxCapacity) throw new InvalidOperationException();
            
            this.Capacity += addedCapacity;
        }
    }
}