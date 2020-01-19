namespace ChainOfResponsibilityPattern.Handler
{
    public class EvenHandler : Handler
    {
        public override string Handle(int data)
        {
            if (data > 0 && data % 2 == 0)
            {
                return $"{data} is Even.";
            }
            return base.Handle(data);
        }
    }
}
