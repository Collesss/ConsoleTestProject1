using ConsoleAppProject1.CommandHandler.Default.Command.Exceptions;
using ConsoleAppProject1.CommandHandler.Default.Command.Interfaces;
using ConsoleAppProject1.CommandHandler.Exceptions;
using ConsoleAppProject1.CommandHandler.Interfaces;
using System.Text.RegularExpressions;

namespace ConsoleAppProject1.CommandHandler.Default.Implementation
{
    public class CommandHandler : ICommandHandler
    {
        private readonly IDictionary<string, ICommand> commands;

        public CommandHandler(IDictionary<string, ICommand> commands) 
        {
            this.commands = commands ?? throw new ArgumentNullException(nameof(commands));
        }

        public void HandleCommand(string command, TextReader textReader, TextWriter textWriter)
        {
            //Regex regEx = new Regex("((?<path>[^>\n]+)>)(?<comm>[^\n ]+)?(?<args>((?<arg>[^\n ]+)| +)+)?", RegexOptions.None, TimeSpan.FromSeconds(5));
            Regex regEx = new Regex("(?<comm>[^\n ]+)?(?<args>((?<arg>[^\n ]+)| +)+)?", RegexOptions.None, TimeSpan.FromSeconds(5));

            string comm = string.Empty;
            string[] args = Array.Empty<string>();

            if (regEx.IsMatch(command))
            {
                MatchCollection matches = regEx.Matches(command);

                Match match = regEx.Match(command);

                //path = match.Groups["path"].Value;
                comm = match.Groups["comm"].Value;
                args = match.Groups["arg"].Captures.Select(argC => argC.Value).ToArray();

                if(commands.TryGetValue(comm, out ICommand commandExec))
                {
                    try
                    {
                        commandExec.HandleCommand(args, textReader, textWriter);
                        return;
                    }
                    catch(CommandException e)
                    {
                        throw new CommandHandlerException("Error. While call handler command.", e);
                    }
                    catch (Exception e)
                    {
                        throw new CommandHandlerException("Unknow error.", e);
                    }
                }
                else
                {
                    throw new CommandHandlerException("Error. Not exit command.");
                }
            }

            throw new CommandHandlerException("Error. While processing command.");
        }
    }
}
