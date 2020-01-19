using CommandPattern.Models;

using System;

namespace CommandPattern.Commands
{
    public class ListCommand : ICommandFactory, ICommand
    {
        public string Name => "list";

        public string Description => "\n>>> List all employees data\n\tExample: list\n";

        public ICommand Create(string[] args)
        {
            if (Name == args[0].ToLower())
            {
                return new ListCommand();
            }
            return null;
        }

        public void Execute()
        {
            foreach (var employee in Employees.Data)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
