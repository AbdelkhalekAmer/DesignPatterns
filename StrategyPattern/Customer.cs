namespace StrategyPattern
{
    public class Customer
    {
        public string Name { get; set; }
        public MembershipTypeEnum MembershipType { get; set; }
    }

    public enum MembershipTypeEnum
    {
        Regular,
        Pro,
        Premium
    }
}
