using System;

namespace strategy_example.QuackStrategies
{
    public class QuackStrategy : IQuackStrategy
    {
        public void Quack()
        {
            Console.WriteLine("Quack strategy");
        }
    }
}
