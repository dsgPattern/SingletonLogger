using System.Diagnostics;

namespace Logger
{
    public class EventLogger : LoggerBase
    {
        public override void Log(string message)
        {
            EventLog.WriteEntry("Application", message, EventLogEntryType.Information);
        }
    }
}
