namespace DecoratorPattern.Models
{
    public class SmallPizza : IPizza
    {
        public string Description => "Small Pizza";

        public double CalculateCost()
        {
            return 3.00;
        }
    }
}
