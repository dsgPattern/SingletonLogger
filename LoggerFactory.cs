namespace Logger
{
    public class LoggerFactory
    {
        private EventLogger _eventLogger;
        private FileLogger _fileLogger;
        private ConsoleLogger _defaultLogger;

        public LoggerBase GetLogger(LogType logType)
        {
            switch (logType)
            {
                case LogType.EventLog:
                    return _eventLogger ??= new EventLogger();

                case LogType.File:
                    return _fileLogger ??= new FileLogger();

                case LogType.Console:
                default:
                    return _defaultLogger ??= new ConsoleLogger();

            }
        }
    }
}
