using System;

namespace StatePattern.States
{
    public class ClosedState : BaseState, ICommands
    {
        private WorkItem _item;
        public ClosedState(WorkItem item)
        {
            _item = item;
        }

        public bool Delete()
        {
            return true;
        }

        public void Edit(string title)
        {
            Console.WriteLine("Can't edit work item, it's already closed.");
        }

        public void Print()
        {
            Print(_item);
        }

        public void SetState(WorkItemStateEnum state)
        {
            Console.WriteLine("Work item is closed and can't change the state.");
        }
    }
}
