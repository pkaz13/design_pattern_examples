using strategy_example.Ducks;
using strategy_example.FlyStrategies;
using strategy_example.QuackStrategies;
using System;

namespace strategy_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck wildDuck = new WildDuck(new WingsStrategy(), new QuackStrategy());
            Duck smallDuck = new SmallDuck(new ParachuteStrategy(), new SquealStrategy());

            wildDuck.Print();
            wildDuck.DoFly();
            wildDuck.DoQuack();

            smallDuck.Print();
            smallDuck.DoFly();
            smallDuck.DoQuack();

            Console.WriteLine("CHANGE FLY STRATEGY:");
            smallDuck.SetFlyStrategy(new WingsStrategy());
            smallDuck.DoFly();
        }
    }
}
