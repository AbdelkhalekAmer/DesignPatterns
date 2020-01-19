namespace ChainOfResponsibilityPattern.Handler
{
    public abstract class Handler
    {
        protected Handler _handler;
        public Handler()
        {
            _handler = LastChainHandler.Instance;
        }

        public virtual string Handle(int data)
        {
            return _handler.Handle(data);
        }

        public virtual Handler RegisterNext(Handler handler)
        {
            _handler = handler;
            return this;
        }

    }
}
