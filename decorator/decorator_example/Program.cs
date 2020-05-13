using System;
using decorator_example.Decorators;
using decorator_example.Drinks;

namespace decorator_example
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrink espresso = new Espresso();
            Console.WriteLine($"Drink: {espresso.Description} Price: {espresso.Price}");

            espresso = new Chocolate(espresso);
            espresso = new Milk(espresso);
            Console.WriteLine($"Drink: {espresso.Description} Price: {espresso.Price}");
        }
    }
}
