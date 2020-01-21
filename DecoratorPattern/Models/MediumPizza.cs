namespace DecoratorPattern.Models
{
    public class MediumPizza : IPizza
    {
        public string Description => "Medium Pizza";

        public double CalculateCost()
        {
            return 6.00;
        }
    }
}
