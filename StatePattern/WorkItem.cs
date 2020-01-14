using StatePattern.States;

namespace StatePattern
{
    public class WorkItem : ICommands
    {
        private ICommands stateCommands;

        public int Id { get; set; }
        public string Title { get; set; }

        private WorkItemStateEnum state;
        public WorkItemStateEnum State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
                switch (state)
                {
                    case WorkItemStateEnum.Proposed:
                        stateCommands = new ProposedState(this);
                        break;
                    case WorkItemStateEnum.Active:
                        stateCommands = new ActiveState(this);
                        break;
                    case WorkItemStateEnum.Resolved:
                        stateCommands = new ResolvedState(this);
                        break;
                    case WorkItemStateEnum.Closed:
                        stateCommands = new ClosedState(this);
                        break;
                }
            }
        }

        public override string ToString()
        {
            return $">>>    Id:{Id}\n" +
                   $">>> Title:{Title}\n" +
                   $">>> State:{State}";
        }

        public bool Delete()
        {
            var canDelete = stateCommands.Delete();
            if (canDelete)
            {
                WorkItemStorage.items.Remove(this);
            }
            return canDelete;
        }

        public void Edit(string title)
        {
            stateCommands.Edit(title);
        }

        public void Print()
        {
            stateCommands.Print();
        }

        public void SetState(WorkItemStateEnum state)
        {
            stateCommands.SetState(state);
        }
    }

    public enum WorkItemStateEnum
    {
        Proposed,
        Active,
        Resolved,
        Closed
    }

}
