namespace StatePattern
{
    public interface ICommands
    {
        bool Delete();
        void Edit(string title);
        void Print();
        void SetState(WorkItemStateEnum state);
    }
}
