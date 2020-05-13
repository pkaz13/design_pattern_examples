using decorator_example.Drinks;

namespace decorator_example.Decorators
{
    public class Milk : IIngredientDecorator
    {
        private IDrink _drink;

        public string Description => _drink.Description + ", Milk";

        public double Price => _drink.Price + 0.5;

        public Milk(IDrink drink)
        {
            _drink = drink;
        }
    }
}
