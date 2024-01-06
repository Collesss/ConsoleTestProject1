using ConsoleAppProject1.CommandHandler.Default.Command.Interfaces;

namespace ConsoleAppProject1.CommandHandler.Default.Command.Exit.Implementation
{
    public class CommandExit : ICommand
    {
        public void HandleCommand(string[] args, TextReader textReader, TextWriter textWriter)
        {
            Environment.Exit(0);
        }
    }
}
