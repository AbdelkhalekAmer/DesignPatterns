using CommandPattern.Models;

using System;
using System.Linq;

namespace CommandPattern.Commands
{
    public class DeleteCommand : ICommandFactory, ICommand
    {
        public int Id { get; set; }
        public string Name => "delete";

        public string Description => "\n>>> Delete employee data by id\n\tExample: delete 5\n";

        public ICommand Create(string[] args)
        {
            if (Name == args[0].ToLower() && int.TryParse(args[1], out int id))
            {
                return new DeleteCommand() { Id = id };
            }
            return null;
        }

        public void Execute()
        {
            var employees = DeleteEmployee(Id);
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        private Employee[] DeleteEmployee(int id)
        {
            var employee = Employees.Data.FirstOrDefault(x => x.Id == id);
            Employees.Data.Remove(employee);
            return Employees.Data.ToArray();
        }

    }
}
