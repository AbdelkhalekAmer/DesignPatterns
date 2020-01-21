namespace DecoratorPattern.Models
{
    public interface IPizza
    {
        string Description { get; }
        double CalculateCost();
    }
}
