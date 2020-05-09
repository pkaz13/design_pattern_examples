using strategy_example.FlyStrategies;
using strategy_example.QuackStrategies;

namespace strategy_example.Ducks
{
    public abstract class Duck
    {
        protected IFlyStrategy _flyStrategy;
        protected IQuackStrategy _quackStrategy;

        public Duck(IFlyStrategy flyStrategy, IQuackStrategy quackStrategy)
        {
            _flyStrategy = flyStrategy;
            _quackStrategy = quackStrategy;
        }

        public void DoFly()
        {
            _flyStrategy.Fly();
        }

        public void DoQuack()
        {
            _quackStrategy.Quack();
        }

        public void SetFlyStrategy(IFlyStrategy flyStrategy)
        {
            _flyStrategy = flyStrategy;
        }

        public void SetQuackStrategy(IQuackStrategy quackStrategy)
        {
            _quackStrategy = quackStrategy;
        }

        public abstract void Print();
    }
}
