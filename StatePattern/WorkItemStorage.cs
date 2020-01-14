using System;
using System.Collections.Generic;

namespace StatePattern
{
    public static class WorkItemStorage
    {
        public static List<WorkItem> items = new List<WorkItem>() {
            new WorkItem()
            {
                Id = 1,
                Title = "Work Item 1",
                State = WorkItemStateEnum.Proposed
            },
            new WorkItem()
            {
                Id = 2,
                Title = "Work Item 2",
                State = WorkItemStateEnum.Active
            }
        };
        
        public static void GetAll()
        {
            Console.WriteLine(">>> All Data:");
            foreach (var item in items)
            {
                Console.WriteLine($">>>    {item.Title}");
            }
        }

    }
}
