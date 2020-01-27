using System;

namespace ChainOfResponsibilityPattern.Handler
{
    public class LastChainHandler : Handler
    {
        public static LastChainHandler Instance { get; } = new LastChainHandler();

        static LastChainHandler()
        {

        }

        public override string Handle(int data)
        {
            return $"No handlers for the number: {data}";
        }

        public override Handler RegisterNext(Handler handler)
        {
            throw new ArgumentException("This is the last chain handler, Which can't register next handlers to it.", "handler");
        }
    }
}
