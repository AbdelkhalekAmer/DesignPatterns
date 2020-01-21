using DecoratorPattern.Models;

namespace DecoratorPattern.Decorators
{
    public class ChickenDecorator : PizzaDecorator
    {
        public ChickenDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string Description => $"{base.Description}, Chicken";
        public override double CalculateCost()
        {
            return base.CalculateCost() + 3.50;
        }

    }
}
