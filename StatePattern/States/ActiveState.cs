using System;

namespace StatePattern.States
{
    public class ActiveState : BaseState, ICommands
    {
        private WorkItem _item;
        public ActiveState(WorkItem item)
        {
            _item = item;
        }
        public bool Delete()
        {
            Console.WriteLine("Work item is already active, Can't delete this item.");
            return false;
        }

        public void Edit(string title)
        {
            _item.Title = title;
        }

        public void Print()
        {
            Print(_item);
        }

        public void SetState(WorkItemStateEnum state)
        {
            switch (state)
            {
                case WorkItemStateEnum.Active:
                    Console.WriteLine("Work item is already in active state");
                    break;
                case WorkItemStateEnum.Proposed:
                case WorkItemStateEnum.Resolved:
                    _item.State = state;
                    break;
                default:
                    Console.WriteLine("Work item is in Active state");
                    break;
            }
        }
    }
}
