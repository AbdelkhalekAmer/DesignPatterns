using System;

namespace StatePattern.States
{
    public class ProposedState : BaseState, ICommands
    {
        private WorkItem _item;
        public ProposedState(WorkItem item)
        {
            _item = item;
        }

        public bool Delete()
        {
            return true;
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
                    _item.State = state;
                    break;
                case WorkItemStateEnum.Proposed:
                    Console.WriteLine("Work item is already proposed.");
                    break;
                default:
                    Console.WriteLine("Work item is not Active.");
                    break;
            }
        }
    }
}
