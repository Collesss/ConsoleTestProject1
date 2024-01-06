using ConsoleAppProject1.CommandHandler.Default.Command.Cd.Implementation;
using ConsoleAppProject1.CommandHandler.Default.Command.Dir.Implementation;
using ConsoleAppProject1.CommandHandler.Default.Command.Exit.Implementation;
using ConsoleAppProject1.CommandHandler.Default.Command.Interfaces;
using ConsoleAppProject1.CommandHandler.Default.Command.Test.Implementation;
using ConsoleAppProject1.CommandHandler.Exceptions;
using ConsoleAppProject1.CommandHandler.Interfaces;
using commHndl = ConsoleAppProject1.CommandHandler.Default.Implementation;

namespace ConsoleAppProject1
{
    internal class Program
    {
        static readonly Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>()
        {
            ["cd"] = new CommandCd(),
            ["dir"] = new CommandDir(),
            ["exit"] = new CommandExit(),
            ["test"] = new CommandTest()
        };

        static void Main(string[] args)
        {
            ICommandHandler commandHandler = new commHndl::CommandHandler(commands);

            //Console.Write($"{currDir}");

            while (true)
            {
                Console.Write($"{Directory.GetCurrentDirectory()}>");
                
                try
                {
                    commandHandler.HandleCommand(Console.ReadLine(), Console.In, Console.Out);
                }
                catch (CommandHandlerException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}