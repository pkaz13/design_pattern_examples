using strategy_example.FlyStrategies;
using strategy_example.QuackStrategies;
using System;

namespace strategy_example.Ducks
{
    public class SmallDuck : Duck
    {
        public SmallDuck(IFlyStrategy flyStrategy, IQuackStrategy quackStrategy) : base(flyStrategy, quackStrategy) { }
        public override void Print()
        {
            Console.WriteLine($"Small duck");
        }
    }
}
