using CommandPattern.Models;

using System;

namespace CommandPattern.Commands
{
    public class AddCommand : ICommandFactory, ICommand
    {
        public string employeeName { get; set; }
        public string employeeJob { get; set; }

        public string Name => "add";

        public string Description => "\n>>> Add new employee data\n\tExample: add employee_name employee_job\n";

        public ICommand Create(string[] args)
        {
            if (Name == args[0].ToLower())
            {
                return new AddCommand() { employeeName = args[1], employeeJob = args[2] };
            }
            return null;
        }

        public void Execute()
        {
            Console.WriteLine(AddNewEmployee(employeeName, employeeName));
        }

        private string AddNewEmployee(string name, string job)
        {
            var employee = new Employee()
            {
                Id = Employees.Data.Count + 1,
                Name = name,
                Job = job
            };
            Employees.Data.Add(employee);
            return $"Employee with ID {employee.Id} is added.";
        }

    }
}
