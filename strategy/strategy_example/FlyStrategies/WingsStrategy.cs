using System;

namespace strategy_example.FlyStrategies
{
    public class WingsStrategy : IFlyStrategy
    {
        public void Fly()
        {
            Console.WriteLine("Wings strategy");
        }
    }
}
