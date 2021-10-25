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

            //var instance1 = LoggerSingleton.Instance;
            //var instace2 = LoggerSingleton.Instance;

            // Same instance
            //if (instance1 == instace2)
            //{
            //    LoggerSingleton.Instance.Log("Equal");
            //}

            //LoggerSingleton.Instance.Log("!!!!!!!!!!!!!!!!!!1");


            TestMultiThreading();

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
            LoggerSingleton.Instance.Log(LoggerSingleton.Instance.Counter.ToString());
        }
    }
}
