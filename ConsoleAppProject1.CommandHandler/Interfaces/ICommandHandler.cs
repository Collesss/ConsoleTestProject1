namespace ConsoleAppProject1.CommandHandler.Interfaces
{
    public interface ICommandHandler
    {
        public void HandleCommand(string command, TextReader textReader, TextWriter textWriter);
    }
}
