using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class LoggerSingleton
    {
        private static LoggerBase _logger;

        private LoggerSingleton()
        {

        }

        public static LoggerBase Instance
        {
            get
            {
                if (_logger == null)
                {
                    _logger = new ConsoleLogger();

                }

                return _logger;
            }
        }
    }
}
