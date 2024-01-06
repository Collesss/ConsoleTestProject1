namespace ConsoleAppProject1.CommandHandler.Exceptions
{
    public class CommandHandlerException : Exception
    {
        public CommandHandlerException() { }

        public CommandHandlerException(string message) : base(message) { } 

        public CommandHandlerException(string message, Exception innerException) : base(message, innerException) { }
    }
}
