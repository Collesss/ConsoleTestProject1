namespace ConsoleAppProject1.CommandHandler.Default.Command.Interfaces
{
    public interface ICommand
    {
        public void HandleCommand(string[] args, TextReader textReader, TextWriter textWriter);
    }
}
