using decorator_example.Drinks;

namespace decorator_example.Decorators
{
    public class Chocolate : IIngredientDecorator
    {
        private IDrink _drink;

        public double Price => _drink.Price + 0.2;
        public string Description => _drink.Description + ", Chocolate";

        public Chocolate(IDrink drink)
        {
            _drink = drink;
        }
    }
}
