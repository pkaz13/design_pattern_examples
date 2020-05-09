using System;

namespace strategy_example.FlyStrategies
{
    public class ParachuteStrategy : IFlyStrategy
    {
        public void Fly()
        {
            Console.WriteLine("Parachute strategy");
        }
    }
}
