using System;

namespace Logger
{
    class ConsoleLogger:LoggerBase
    {
        public override void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
