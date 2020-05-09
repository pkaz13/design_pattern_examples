using strategy_example.FlyStrategies;
using strategy_example.QuackStrategies;
using System;

namespace strategy_example.Ducks
{
    public class WildDuck : Duck
    {

        public WildDuck(IFlyStrategy flyStrategy, IQuackStrategy quackStrategy) : base(flyStrategy, quackStrategy) { }
        public override void Print()
        {
            Console.WriteLine($"Wild duck");
        }
    }
}
