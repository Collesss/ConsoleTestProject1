using ConsoleAppProject1.CommandHandler.Default.Command.Interfaces;

namespace ConsoleAppProject1.CommandHandler.Default.Command.Dir.Implementation
{
    public class CommandDir : ICommand
    {
        public void HandleCommand(string[] args, TextReader textReader, TextWriter textWriter)
        {
            string path = Directory.GetCurrentDirectory();

            Directory.GetDirectories(path)
                .ToList()
                .ForEach(fullPath => textWriter.WriteLine($"<DIR>\t{Path.GetFileName(fullPath)}"));

            Directory.GetFiles(path)
                .ToList()
                .ForEach(fullPath => textWriter.WriteLine($"\t{Path.GetFileName(fullPath)}"));
        }
    }
}
