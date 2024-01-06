using ConsoleAppProject1.CommandHandler.Default.Command.Interfaces;

namespace ConsoleAppProject1.CommandHandler.Default.Command.Cd.Implementation
{
    public class CommandCd : ICommand
    {
        public void HandleCommand(string[] args, TextReader textReader, TextWriter textWriter)
        {
            string toPath = args[0];

            Directory.SetCurrentDirectory(toPath);

            /*
            if (Directory.Exists($"{path}{toPath}"))
                return $"{path}{toPath}";
            else if (Directory.Exists($"{path}\\{toPath}"))
                return $"{path}\\{toPath}";
            else if (Directory.Exists(toPath))
                return toPath;
            */

            //throw new CommandException("Not exit path.");
        }

    }
}