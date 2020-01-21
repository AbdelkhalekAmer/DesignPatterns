using DecoratorPattern.Decorators;
using DecoratorPattern.Models;

using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new LargePizza();
            pizza = new ChickenDecorator(pizza);
            pizza = new CheeseDecorator(pizza);

            Console.WriteLine($"Pizza: {pizza.Description}");
            Console.WriteLine($"\t>>> Price: {pizza.CalculateCost():c2}");

        }
    }
}
