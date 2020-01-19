using ChainOfResponsibilityPattern.Handler;

using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = 5;
            var handler = new EvenHandler()
                .RegisterNext(new OddHandler());

            Console.WriteLine(handler.Handle(data));

        }
    }
}
