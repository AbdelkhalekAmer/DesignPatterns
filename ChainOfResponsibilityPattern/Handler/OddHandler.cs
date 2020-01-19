namespace ChainOfResponsibilityPattern.Handler
{
    public class OddHandler : Handler
    {
        public override string Handle(int data)
        {
            if (data > 0 && data % 2 != 0)
            {
                return $"{data} is Odd.";
            }
            return base.Handle(data);
        }
    }
}
