namespace decorator_example.Drinks
{
    public class Espresso : IDrink
    {
        public string Description { get; private set; }

        public double Price => 1.5;

        public Espresso()
        {
            Description = "Espresso";
        }
    }
}
