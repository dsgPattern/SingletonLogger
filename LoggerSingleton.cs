using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class LoggerSingleton
    {
        private static LoggerSingleton _logger;

        private LoggerSingleton()
        {
        }

        public static LoggerSingleton Instance
        {
            get
            {
                if (_logger == null)
                {
                    _logger = new LoggerSingleton();

                }

                return _logger;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
