using System.Collections.Generic;

namespace CommandPattern.Models
{
    public static class Employees
    {
        public static List<Employee> Data = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                Name = "Abdelkhalek",
                Job = "Software Engineer"
            },
            new Employee()
            {
                Id = 2,
                Name = "Employee A",
                Job = "Quality Engineer"
            },
            new Employee()
            {
                Id = 3,
                Name = "Employee B",
                Job = "Lead Software Engineer"
            },
        };
    }
}
