using CommandPattern.Commands;

using System.Linq;

namespace CommandPattern
{
    public class CommandParser
    {
        private readonly ICommandFactory[] _commands;
        public CommandParser(ICommandFactory[] commands)
        {
            _commands = commands;
        }

        public ICommand Parse(string[] args)
        {
            var command = _commands.FirstOrDefault(x => x.Name == args[0].ToLower());
            return command.Create(args);
        }

    }
}
