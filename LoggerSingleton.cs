using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class LoggerSingleton
    {
        private static readonly object _lockObject = new object();

        //can create the instance from the start - keep in mind Resource usage, how it impacts the app if the resource is created before being needed
        private static LoggerSingleton _logger;// = new LoggerSingleton();
        private static int _counter = 0;
        
        private LoggerSingleton()
        {
        }

       
        public static LoggerSingleton Instance
        {
            get
            {
                if (_logger == null)
                {
                    // lock on _lockObject to make sure that threads are not creating multiple instances in the same time.
                    // ensure exclusive access(in sequence, one after the previous finishes)
                    lock (_lockObject)
                    {
                        if (_logger == null)
                        {
                            _logger = new LoggerSingleton();
                            _counter++;
                        }
                    }
                }

                return _logger;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public int Counter => _counter;
    }
}
