namespace Command;

public class CommandInvoker
{
    private readonly Stack<ICommand> _executedCommands = new Stack<ICommand>();
    private readonly Stack<ICommand> _undoneCommands = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _executedCommands.Push(command);
        _undoneCommands.Clear();
    }

    public void UndoLastCommand()
    {
        if (_executedCommands.Count <= 0) return;
        var command = _executedCommands.Pop();
        command.Undo();
        _undoneCommands.Push(command);
    }

    public void RedoLastCommand()
    {
        if (_undoneCommands.Count <= 0) return;
        var command = _undoneCommands.Pop();
        command.Execute();
        _executedCommands.Push(command);
    }
}