using System;
using System.Threading;
using System.Threading.Tasks;

namespace Logger
{
    class Program
    {
        private static DateTime startTime = DateTime.Now.AddSeconds(1);

        static void Main(string[] args)
        {
            var logger = new LoggerFactory().GetLogger(LogType.EventLog);

            // what happens if multiple Log requests are made in the same time? - e.g. when writing to file/eventlog - should lock or not?
            logger.Log("Test");
            
          
            
            //LoggerSingleton.Instance.Log("!!!!!!!!!!!!!!!!!!1");

            Console.ReadLine();
        }


        private static void TestMultiThreading()
        {
            var th1 = new Thread(LogInstanceHashCode);
            var th2 = new Thread(LogInstanceHashCode);

            th1.Start();
            th2.Start();
        }

        private static void LogInstanceHashCode()
        {
            while (DateTime.Now < startTime)
            {
                //wait for start
            }

            //both threads will execute code here concurrently
            LoggerSingleton.Instance.Log(LoggerSingleton.Instance.GetHashCode().ToString());
        }
    }
}
