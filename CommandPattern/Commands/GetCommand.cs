using CommandPattern.Models;

using System;
using System.Linq;

namespace CommandPattern.Commands
{
    public class GetCommand : ICommandFactory, ICommand
    {
        public int Id { get; set; }
        public string Name => "get";

        public string Description => "\n>>> Get employee data by id\n\tExample: get 5\n";

        public GetCommand()
        {

        }

        public ICommand Create(string[] args)
        {
            if (Name == args[0].ToLower() && int.TryParse(args[1], out int id))
            {
                return new GetCommand() { Id = id };
            }
            return null;
        }

        public void Execute()
        {
            Console.WriteLine(GetEmployeeById(Id));
        }

        private string GetEmployeeById(int id)
        {
            var employee = Employees.Data.FirstOrDefault(x => x.Id == id);
            return employee != null ? employee.ToString() : $"No employee data for the ID: {id}";
        }

    }
}
