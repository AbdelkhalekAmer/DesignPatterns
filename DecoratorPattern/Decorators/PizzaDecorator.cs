using DecoratorPattern.Models;

namespace DecoratorPattern.Decorators
{
    public abstract class PizzaDecorator : IPizza
    {
        public virtual string Description => _pizza.Description;

        private readonly IPizza _pizza;
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual double CalculateCost()
        {
            return _pizza.CalculateCost();
        }
    }
}
