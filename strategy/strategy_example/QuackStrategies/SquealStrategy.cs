using System;

namespace strategy_example.QuackStrategies
{
    public class SquealStrategy : IQuackStrategy
    {
        public void Quack()
        {
            Console.WriteLine("Squeal strategy");
        }
    }
}
