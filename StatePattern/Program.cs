namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var workItem1 = WorkItemStorage.items[0];
            var workItem2 = WorkItemStorage.items[1];

            workItem1.Print();
            workItem1.Edit("Work Item 1 edited");
            workItem1.Print();
            workItem1.SetState(WorkItemStateEnum.Active);
            workItem1.Print();
            workItem1.Delete();
            workItem2.Print();
            workItem2.Delete();
            workItem2.SetState(WorkItemStateEnum.Resolved);
            workItem2.Print();
            workItem2.SetState(WorkItemStateEnum.Closed);
            workItem2.Print();
            workItem2.Delete();
            WorkItemStorage.GetAll();
        }
    }
}
