using CommandPattern.Commands;

namespace CommandPattern
{
    public interface ICommandFactory
    {
        string Name { get; }
        string Description { get; }

        ICommand Create(string[] args);
    }
}
