namespace DecoratorPattern.Models
{
    public class LargePizza : IPizza
    {
        public string Description => "Large Pizza";

        public double CalculateCost()
        {
            return 9.00;
        }
    }
}
