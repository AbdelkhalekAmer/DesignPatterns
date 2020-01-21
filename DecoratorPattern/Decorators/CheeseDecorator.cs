using DecoratorPattern.Models;

namespace DecoratorPattern.Decorators
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string Description => $"{base.Description}, Cheese";
        public override double CalculateCost()
        {
            return base.CalculateCost() + 1.00;
        }

    }
}
