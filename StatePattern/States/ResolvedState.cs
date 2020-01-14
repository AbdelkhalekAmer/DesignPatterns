using System;

namespace StatePattern.States
{
    public class ResolvedState : BaseState, ICommands
    {
        private WorkItem _item;
        public ResolvedState(WorkItem item)
        {
            _item = item;
        }

        public bool Delete()
        {
            Console.WriteLine("can't delete item, it must be closed first.");
            return false;
        }

        public void Edit(string title)
        {
            Console.WriteLine("Can't edit item after being resolved");
        }

        public void Print()
        {
            Print(_item);
        }

        public void SetState(WorkItemStateEnum state)
        {
            switch (state)
            {
                case WorkItemStateEnum.Proposed:
                    Console.WriteLine("Can't set work item to proposed.");
                    break;
                case WorkItemStateEnum.Active:
                case WorkItemStateEnum.Closed:
                    _item.State = state;
                    break;
                case WorkItemStateEnum.Resolved:
                    Console.WriteLine("Work item is already resolved.");
                    break;
            }
        }
    }
}
