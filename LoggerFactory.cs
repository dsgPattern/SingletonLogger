namespace Logger
{
    public class LoggerFactory
    {
        public LoggerBase GetLogger(LogType logType)
        {
            switch (logType)
            {
                case LogType.EventLog:
                    return new EventLogger();

                case LogType.File:
                    return new FileLogger();

                case LogType.Console:
                default:
                    return new ConsoleLogger();

            }
        }
    }
}
