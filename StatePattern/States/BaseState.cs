using System;

namespace StatePattern.States
{
    public class BaseState
    {
        public void Print(WorkItem item)
        {
            Console.WriteLine(item);
        }
    }
}
