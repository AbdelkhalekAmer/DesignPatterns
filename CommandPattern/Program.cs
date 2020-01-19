using CommandPattern.Commands;

using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var availableCommands = GetAvailableCommands();
            if (availableCommands.Length > 0)
            {
                PrintAvailableCommands(availableCommands);
            }

            var parser = new CommandParser(availableCommands);
            var command = parser.Parse(args);

            if (command != null)
            {
                command.Execute();
            }
            else
            {
                // Replace Null object
            }

        }
        static ICommandFactory[] GetAvailableCommands()
        {
            return new ICommandFactory[]
            {
                new ListCommand(),
                new GetCommand(),
                new AddCommand(),
                new DeleteCommand()
            };
        }

        static void PrintAvailableCommands(ICommandFactory[] commands)
        {
            Console.WriteLine("\n===============================================\n");
            Console.WriteLine("Available Commands:");
            foreach (var command in commands)
            {
                Console.WriteLine(command.Description);
            }
            Console.WriteLine("\n===============================================\n");
        }

    }
}
